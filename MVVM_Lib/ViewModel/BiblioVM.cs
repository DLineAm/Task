using MVVM_Lib.Model;
using MVVM_Lib.View;
using MVVM_Lib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Lib
{
    class BiblioVM : INotifyPropertyChanged
    {

        public bool? DialogResult = null;
        
        BiblioEntities db = new BiblioEntities();

        DisplayRootRegistry displayRoot = new DisplayRootRegistry();

        public enum WindowMode
        {
            Add, Change
        }

        private ModelCommand closeWindowCommand;

        public ICommand CloseWindowCommand
        {
            get
            {
                return closeWindowCommand ??
                    (closeWindowCommand = new ModelCommand(param => this.CloseWindow()));
            }
        }

        private void CloseWindow()
        {
            this.DialogResult = true;
        }

        private ModelCommand addReaderCommand;

        public ICommand AddReaderCommand
        {
            get
            {
                return addReaderCommand ??
                    (addReaderCommand = new ModelCommand(param => this.StartWindow(WindowMode.Add)));
            }
        }


        private ModelCommand changeReaderCommand;
        public ICommand ShowReaderCommand
        {
            get
            {
                return changeReaderCommand ??
                    (changeReaderCommand = new ModelCommand(param => this.StartWindow(WindowMode.Change)));
            }
        }

        private ModelCommand deleteReaderCommand;
        public ICommand DeleteReaderCommand { get 
            { 
                return deleteReaderCommand ??
                    (deleteReaderCommand = new ModelCommand(param => this.DeleteReader()));
            }
        }

        public BiblioVM()
        {

            //displayRoot.RegisterWindowType<BiblioVM, MainWindow>();
            displayRoot.RegisterWindowType<ReaderChangeVM, ReaderChange>();


            FillReaders();

            if (Readers == null || Readers.Count == 0)
            {
                db.Readers.AddRange(Reader.FillReaders());
                db.SaveChanges();
                FillReaders();
            }
        }
  

        private List<Reader> _readers;
        public List<Reader> Readers { get => _readers; 
            set
            { 
                _readers = value;
                NotifyPropertyChanged();
            } 
        }


        private Reader _selectedReader;
        public Reader SelectedReader { get => _selectedReader; 
            set
            {
                _selectedReader = value;
                NotifyPropertyChanged();
            }
        }        

        private void FillReaders()
        {
            Readers = db.Readers.ToList();
        }

        private string _filterText;
        public string FilterText { get => _filterText;
            set 
            {
                _filterText = value;
                SearchReaders();
                NotifyPropertyChanged();
            }
        }

        private void SearchReaders()
        {
            if (string.IsNullOrWhiteSpace(FilterText))
            {
                Readers = db.Readers.ToList();
            }
            Readers = Readers.FindAll(p => p.FirstName.Contains(FilterText) || p.LastName.Contains(FilterText) || p.MiddleName.Contains(FilterText));
            if (Readers.Count == 0)
                Readers = db.Readers.ToList();
        }


        public void DeleteReader()
        {
            this.db.Readers.Remove(SelectedReader);
            this.db.SaveChanges();
            //NotifyPropertyChanged();
            FillReaders();
        }

        protected async void StartWindow(WindowMode wm)
        {
            try
            {
                await RunProgramLogic(wm);
            }
            catch
            { }
                       
        }
        
        private async Task RunProgramLogic(WindowMode wm)
        {
            while (true)
            {
                var vm = new ReaderChangeVM(wm == WindowMode.Change ? SelectedReader : null,
                    wm == WindowMode.Change ? "Изменение читалеля" : "Добавление читателя");
                await displayRoot.ShowModalView(vm);

                await Task.Delay(TimeSpan.FromSeconds(2));
                if (vm.DialogResult == true)
                {
                    switch (wm)
                    {
                        case WindowMode.Add:
                            db.Readers.Add(vm.Reader);
                            break;
                        case WindowMode.Change:
                            SelectedReader = vm.Reader;
                            break;
                    }                    
                    await db.SaveChangesAsync();
                    FillReaders();
                }
                
                displayRoot.HideView(vm);
                break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
