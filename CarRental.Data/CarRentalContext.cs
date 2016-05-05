using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarRental.Business.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Serialization;
using Core.Common.Contracts;


namespace CarRental.Data
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext()
            : base("name=CarRental")
        {
            Database.SetInitializer<CarRentalContext>(null);
        }

        public DbSet<Car> CarSet { get; set; }
        public DbSet<Account> AccountSet { get; set; }
        public DbSet<Rental> RentalSet { get; set; }
        public DbSet<Reservation> ReservationSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<Account>().HasKey<int>(e=>e.AccountId);
            modelBuilder.Entity<Car>().HasKey<int>(e => e.CarId);
            modelBuilder.Entity<Rental>().HasKey<int>(e => e.RentalId);
            modelBuilder.Entity<Reservation>().HasKey<int>(e => e.ReservationId);

        }

    }
}
