using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lib.Model
{
    class Reader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public List<BookTakings> Takings { get; set; }

        public static List<Reader> FillReaders()
        {
            var readers = new List<Reader>
            {
                new Reader{ FirstName = "Vladlen", LastName = "Evsyutin", MiddleName = "Sergeevich"},
                new Reader{ FirstName = "Kavo1", LastName="ln1", MiddleName="mn1" },
                new Reader{ FirstName = "Kavo2", LastName="ln2", MiddleName="mn2" },
                new Reader{ FirstName = "Kavo3", LastName="ln3", MiddleName="mn3" },
                new Reader{ FirstName = "Kavo4", LastName="ln4", MiddleName="mn4" }
            };
            return readers;
        }

    }
}
