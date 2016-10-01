using System.Data.Entity;
using Books.Entities;
using System.Diagnostics;

namespace Books.Web.DataContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb() : base("DefaultConnection")
        {
            // Prints SQL in the Output (Debug) window
            Database.Log = sql => Debug.Write(sql);
        }

        // To change owner to something other than dbo
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.HasDefaultSchema("notdbo");
            base.OnModelCreating(modelBuilder);
        }
        */

        public DbSet<Book> Books { get; set; }
    }
}