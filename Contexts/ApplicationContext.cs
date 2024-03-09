using Microsoft.EntityFrameworkCore;
using UsersMicroservice.Models;
using Shared.Utils;

namespace UsersMicroservice.Contexts {
    public class ApplicationContext : DbContext {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<UserModel>().HasData(new UserModel() {
                Id = 1,
                Username = "admin",
                Password = Password.Hash("admin")
            });
        }

        public DbSet<UserModel> Users { get; set; }
    }
}