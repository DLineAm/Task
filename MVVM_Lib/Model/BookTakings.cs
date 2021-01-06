using System;

namespace MVVM_Lib.Model
{
    class BookTakings
    {
        public int Id { get; set; }
        public DateTime? TakeDate { get; set; }
        public DateTime? GiveDate { get; set; }

        public int ReaderId { get; set; }
        public Reader Reader { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
