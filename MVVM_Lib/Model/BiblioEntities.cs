using System.Data.Entity;

namespace MVVM_Lib.Model
{
    class BiblioEntities : DbContext
    {
        public BiblioEntities()
            :base("SqlConnection")
        { }

        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTakings> BookTakings { get; set; }
    }
}
