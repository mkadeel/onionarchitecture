using System.Configuration;
using System.Data.Entity;
using Onion.Domain.Models;
using Onion.Interfaces;

namespace Onion.Data
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
       
        public ApplicationDBContext(string connectionString = "ApplicationConnectionString")
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public IDbSet<User> Users { get; set; }
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
