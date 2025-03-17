using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Biblio.Models;

namespace Biblio.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           // options.UseSqlServer("Data Source=.;Initial Catalog=BibliothequeDB;Integrated Security=True;");
        }
    }
}
