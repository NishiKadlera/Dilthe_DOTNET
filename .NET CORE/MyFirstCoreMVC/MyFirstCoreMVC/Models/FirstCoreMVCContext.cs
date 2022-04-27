using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyFirstCoreMVC.Models
{
    public partial class FirstCoreMVCContext : DbContext
    {
        public FirstCoreMVCContext()
        {
        }

        public FirstCoreMVCContext(DbContextOptions<FirstCoreMVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mvc> Mvcs { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
          //  if (!optionsBuilder.IsConfigured)
          //  {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
              //  optionsBuilder.UseSqlServer("Server=DESKTOP-PHCT0NL\\SQLEXPRESS;Database=FirstCoreMVC;Trusted_Connection=True;");
            //}
       // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mvc>(entity =>
            {
                entity.ToTable("MVC");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
