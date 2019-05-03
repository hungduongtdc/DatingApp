using System.IO;
using DatingApp.API.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var contents = JsonConvert.DeserializeObject<DumpModel[]>(File.ReadAllText("DataForSeed/DumpModelData.json"));

            modelBuilder.Entity<DumpModel>().HasData(contents);
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<DumpModel> DumpModel { get; set; }
    }
}