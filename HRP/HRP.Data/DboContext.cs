using HRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Data
{
    public interface IDboContextFactory
    {
        IDboContext GetContext();
    }

    public class DboContextFactory : IDboContextFactory
    {
        public IDboContext GetContext()
        {
            var db = new DboContext("HRP");

            db.Database.Log = Console.WriteLine;

            return db;
        }
    }

    public interface IDboContext
    {
        DbSet<Candidate> Candidates { get; set; }


        void Dispose();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }

    public class DboContext : DbContext, IDboContext
    {
        public DboContext(string nameOrConnectionString) : base(nameOrConnectionString) { }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .ToTable("tbl_User")
            //    .HasKey(u => u.UserID)
            //    .HasOptional(u => u.Role)
            //    .WithMany()
            //    .HasForeignKey(u => u.RoleID);                  

        }
    }
}
