
using System.Collections.Generic;

namespace WpfTask.Windows.Tables
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public List<BookTakings> Takings { get; set; }
    }
}
