using MVVM_Lib.Model;
using MVVM_Lib.View;
using MVVM_Lib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Lib
{
    class BiblioVM : INotifyPropertyChanged
    {
        BiblioEntities db = new BiblioEntities();

        DisplayRootRegistry displayRoot = new DisplayRootRegistry();

        private ModelCommand changeReaderCommand;
        public ICommand ShowReaderCommand
        {
            get
            {
                return changeReaderCommand ??
                    (changeReaderCommand = new ModelCommand(param => this.StartWindow()));
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
            var f = (from a in db.Readers select a).ToList();
            this.Readers = f;
        }

        private string _filterText;
        public string FilterText { get => _filterText;
            set 
            {
                _filterText = value;
                NotifyPropertyChanged();
            }
        }


        public void DeleteReader()
        {
            this.db.Readers.Remove(SelectedReader);
            this.db.SaveChanges();
            //NotifyPropertyChanged();
            FillReaders();
        }

        protected async void StartWindow()
        {
            try
            {
                await RunProgramLogic();
            }
            catch
            { }
                       
        }

        private async Task RunProgramLogic()
        {
            while (true)
            {
                var vm = new ReaderChangeVM(SelectedReader);
                await displayRoot.ShowModalView(vm);

                await Task.Delay(TimeSpan.FromSeconds(2));
                if (vm.DialogResult == true)
                {
                    SelectedReader = vm.Reader;
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
