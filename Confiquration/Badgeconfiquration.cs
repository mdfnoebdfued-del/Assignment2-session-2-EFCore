using fluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApi.Confiquration
{
    public class BadgeConfiguration : IEntityTypeConfiguration<badge>
    {
        public void Configure(EntityTypeBuilder<badge> builder)
        {
            builder.HasKey(b => b.Id);

        }
    }
}
