using System.Collections.Generic;

namespace WpfTask.Windows.Tables
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public List<BookTakings> Takings { get; set; }
    }
}
