using System.Data.Entity;
using DivideAndWalkTheDog.DAL.Entities;

namespace DivideAndWalkTheDog.DAL.EF
{
    public class ApplicationContext:DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Message> Messages { get; set; }

        public ApplicationContext(string connectionString): base(connectionString)
        {
        }

        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new DbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Request>()
            //.HasRequired(a => a.Dog)
            //.WithRequiredDependent(a=>a.)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<Driver>()
            //.HasMany(a => a.Requests)
            //.WithOptional(a => a.Driver)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<Driver>()
            //.HasMany(a => a.Voyages)
            //.WithRequired(a => a.Driver)
            //.WillCascadeOnDelete(true);
        }
    }
}
