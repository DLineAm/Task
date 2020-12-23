using System.Data.Entity;
using WpfTask.Windows.Tables;

namespace WpfTask.Windows
{
    public class ClientContext : DbContext
    {
        public ClientContext()
            : base("DBConnection")
        { }

        public DbSet<Client> Client { get; set; }
        public DbSet<Book> Book { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
