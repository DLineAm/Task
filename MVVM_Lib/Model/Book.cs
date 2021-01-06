using System.Collections.Generic;

namespace MVVM_Lib.Model
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public List<BookTakings> Takings { get; set; }
    }
}
