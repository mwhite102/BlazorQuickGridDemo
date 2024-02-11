using BlazorQuickGrid.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorQuickGrid.Data
{
    public class ContactsContext :DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ContactsDatabase");
        }
    }
}
