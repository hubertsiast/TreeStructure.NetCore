using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TreeStructure.Aplication.Nodes;

namespace TreeStructure.Persistance.Nodes
{
    public class NodeConfiguration : IEntityTypeConfiguration<Node>
    {
        public void Configure(EntityTypeBuilder<Node> builder)
        {
            builder.HasMany(p => p.Childern)
                .WithOne(p => p.Parent)
                .HasForeignKey(p => p.ParentId);
        }
    }
}
