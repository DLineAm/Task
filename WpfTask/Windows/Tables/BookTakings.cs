using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTask.Windows.Tables
{
    public class BookTakings
    {
        public int Id { get; set; }
        public int TakingsAmount { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
