using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TreeStructure.Aplication.Nodes;

namespace TreeStructure.Persistance
{
    public class TreeStructureDbContext : DbContext
    {
        public TreeStructureDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Node> Nodes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(TreeStructureDbContext).Assembly);
        }
    }
}
