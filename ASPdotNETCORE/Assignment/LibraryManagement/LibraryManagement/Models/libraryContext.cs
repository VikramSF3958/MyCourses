using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryManagement.Models
{
    public partial class libraryContext : DbContext
    {
        public libraryContext(DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookcategories> Bookcategories { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Indextable> Indextable { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //    //warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=library;User Id=postgres;Password=postgres;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookcategories>(entity =>
            {
                entity.HasKey(e => e.Cateogoryid)
                    .HasName("bookcategories_pkey");

                entity.ToTable("bookcategories");

                entity.Property(e => e.Cateogoryid).HasColumnName("cateogoryid");

                entity.Property(e => e.Cateogoryname)
                    .IsRequired()
                    .HasColumnName("cateogoryname")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Updatedon)
                    .HasColumnName("updatedon")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.Bookid)
                    .HasName("books_pkey");

                entity.ToTable("books");

                entity.Property(e => e.Bookid).HasColumnName("bookid");

                entity.Property(e => e.Authorname)
                    .HasColumnName("authorname")
                    .HasMaxLength(250);

                entity.Property(e => e.Bookcategoryid).HasColumnName("bookcategoryid");

                entity.Property(e => e.Bookname)
                    .IsRequired()
                    .HasColumnName("bookname")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.Publishedyear).HasColumnName("publishedyear");

                entity.Property(e => e.Updatedon)
                    .HasColumnName("updatedon")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Indextable>(entity =>
            {
                entity.HasKey(e => e.Indexid)
                    .HasName("indextable_pkey");

                entity.ToTable("indextable");

                entity.Property(e => e.Indexid).HasColumnName("indexid");

                entity.Property(e => e.Indexbookcategoryid).HasColumnName("indexbookcategoryid");

                entity.Property(e => e.Indexbookid).HasColumnName("indexbookid");

                entity.HasOne(d => d.Indexbookcategory)
                    .WithMany(p => p.Indextable)
                    .HasForeignKey(d => d.Indexbookcategoryid)
                    .HasConstraintName("bookcateogory_fk");

                entity.HasOne(d => d.Indexbook)
                    .WithMany(p => p.Indextable)
                    .HasForeignKey(d => d.Indexbookid)
                    .HasConstraintName("books_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
