using MVVM_Lib.Model;
using MVVM_Lib.ViewModel;
using System.Windows.Input;

namespace MVVM_Lib
{
    class ReaderChangeVM
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public bool? DialogResult = false;
        public ReaderChangeVM(string title)
        {
            Title = title;
        }
        public ReaderChangeVM(Reader r, string title)
        {
            Reader = new Reader();
            if (r != null)
            {
                Reader = r;
                FirstName = Reader.FirstName;
                LastName = Reader.LastName;
                MiddleName = Reader.MiddleName;
            }

            Title = title;
        }

        private ModelCommand applyCommand;
        public ICommand ApplyCommand 
        {
            get
            {
                return applyCommand ??
                    (applyCommand = new ModelCommand(param => this.ApplyChanges()));
            }
        }

        private void ApplyChanges()
        {
            Reader.FirstName = FirstName;
            Reader.LastName = LastName;
            Reader.MiddleName = MiddleName;
            DialogResult = true;
            //db.SaveChanges();
        }

        private Reader reader;

        public Reader Reader { get => reader; set => reader = value; }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }

        private string firstName;
        private string lastName;
        private string middleName;
    }
}
