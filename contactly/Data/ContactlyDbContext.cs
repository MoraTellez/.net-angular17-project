using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contactly.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace contactly.Data
{
    public class ContactlyDbContext : DbContext
    {
        public ContactlyDbContext(DbContextOptions<ContactlyDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }  
}