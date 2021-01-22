using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<StatePark> StateParks { get; set; }
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NationalPark>()
                .HasData(
                    new NationalPark
                    {

                    }
                );
            builder.Entity<StatePark>()
            .HasData(
                new StatePark
                {

                }
            );
        }
    }
}