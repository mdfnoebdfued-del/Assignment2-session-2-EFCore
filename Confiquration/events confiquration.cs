using fluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace fluentApi.Confiquration
{
    public class events_confiquration:IEntityTypeConfiguration<Models.Event>
    {
        public  void Configure(EntityTypeBuilder<Models.Event> builder)
        {
            builder.  HasOne(e => e.Organizer).WithMany(o => o.events)
             .HasForeignKey(e => e.OrganizerId);
        }
    }
}
