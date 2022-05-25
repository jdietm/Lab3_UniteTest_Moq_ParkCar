using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab3_UniteTest_Moq_ParkCar.Models;

    public class ParkingContext : DbContext
    {
        public ParkingContext (DbContextOptions<ParkingContext> options)
            : base(options)
    {
        
    }

    public ParkingContext()
    {

    }
    public virtual DbSet<Vehicle> Vehicles { get; set; }
    public virtual DbSet<Pass> Passes { get; set; }
    public virtual DbSet<ParkingSpot> ParkingSpots { get; set; }
    public virtual DbSet<Reservation> Reservations { get; set; }

   
   }
