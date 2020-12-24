using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTask.Windows.Tables
{
    public class Report
    {
        public String BookName;
        public int Count;

        public Report(String bookName, int count)
        {
            this.BookName = bookName;
            this.Count = count;
        }
    }
}
