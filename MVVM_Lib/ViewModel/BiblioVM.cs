using MVVM_Lib.Model;
using MVVM_Lib.View;
using MVVM_Lib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Lib
{
    class BiblioVM : INotifyPropertyChanged
    {
        BiblioEntities db = new BiblioEntities();

        private ModelCommand changeReaderCommand;
        public ICommand ShowReaderCommand
        {
            get
            {
                return changeReaderCommand ??
                    (changeReaderCommand = new ModelCommand(param => this.ShowReader()));
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

        public void ShowReader()
        {
            ReaderChangeVM readerChangeVM = new ReaderChangeVM() { Reader = SelectedReader };
            var rcw = new ReaderChange() { DataContext = readerChangeVM };
            ViewShower.Show(rcw, true, b => {
                if (b != null && b.Value) SelectedReader = readerChangeVM.Reader; db.SaveChanges(); });
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
