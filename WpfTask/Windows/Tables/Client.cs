using System.Collections.Generic;

namespace WpfTask.Windows.Tables
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BookTakings> Takings { get; set; }
    }
}
