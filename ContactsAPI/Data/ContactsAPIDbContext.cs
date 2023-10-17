using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContext: DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
