using HyperChainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperChainModel.Context
{
    public class HyperChainContext : DbContext
    {
        public DbSet<RegistryWord> Words { get; set; }
        public DbSet<WordChain> WordChains { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<WordChain>()
                .HasRequired(t => t.Parent)
                .WithMany(t => t.Links)
                .HasForeignKey(d => d.ParentId)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WordChain>()
            //    .HasRequired(t => t.Child)
            //    .WithMany(t => t.Links)
            //    .HasForeignKey(d => d.ChildId)
            //    .WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }
    }
}
