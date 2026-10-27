using fluentApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApi
{
    public class EventHub : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrganizerProfile>(entity =>
            {
               entity.HasKey(e=>e.id);
            });
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventHub).Assembly);
        }
       
    }
}