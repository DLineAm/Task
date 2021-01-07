using MVVM_Lib.Model;
using MVVM_Lib.ViewModel;
using System.Windows.Input;

namespace MVVM_Lib
{
    class ReaderChangeVM
    {
        public bool? DialogResult = false;
        public ReaderChangeVM(Reader r)
        {
            Reader = r;
            FirstName = Reader.FirstName;
            LastName = Reader.LastName;
            MiddleName = Reader.MiddleName;

        }
        private BiblioEntities db = new BiblioEntities();
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
