using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using Train.Entities;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Train.DataAccess;

public class TrainDbContext : DbContext
{
    // ------- Bookings -------
    public DbSet<Entities.Passanger> Passangers { get; set; }
    public DbSet<Entities.Ticket> Tickets { get; set; }
    public DbSet<Entities.Trip> Trips { get; set; }





    // ------- Infrastructures -------

    public DbSet<Entities.Route> Routes { get; set; }

    public DbSet<Entities.RoutePath> RoutePaths { get; set; }

    public DbSet<Entities.Station> Stations { get; set; }

    public DbSet<Entities.TimeTable> TimeTables { get; set; }

    public DbSet<Entities.TrackSegment> TrackSegments { get; set; }

    public DbSet<Entities.WaitPoint> WaitPoints { get; set; }


    // -------  Personnel -------

    public DbSet<Entities.Contact> Contacts { get; set; }
    public DbSet<Entities.Driver> Drivers { get; set; }

    public DbSet<Entities.DriverSchedule> DriverSchedules { get; set; }

    public DbSet<Entities.MedicalCertificate> MedicalCertificates { get; set; }

    public DbSet<Entities.MedicalRecord> MedicalRecords { get; set; }

    public DbSet<Entities.Professionality> Professionalities { get; set; }

    public DbSet<Entities.WorkingDay> WorkingDays { get; set; }

    public DbSet<Entities.WorkingHour> WorkingHours{ get; set; }



    // ------- Assets -------
    public DbSet<Entities.Train> Trains { get; set; }
    public DbSet<Entities.TrainSpecification> TrainSpecifications { get; set; }
    public DbSet<Entities.Wagon> Wagons { get; set; }
    public DbSet<Entities.Seat> Seats { get; set; }

    // ------- Company -------
    public DbSet<Entities.Company> Companies { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TrainDb;Integrated Security=True;Connect Timeout = 30; Encrypt=True;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False;Command Timeout = 30;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entities.Route>()
            .HasOne(r => r.FromStation)
            .WithMany(s => s.StartingRoutes)
            .HasForeignKey(r => r.FromStationId)
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<Entities.Route>()
            .HasOne(r => r.ToStation)
            .WithMany(s => s.EndingRoutes)
            .HasForeignKey(r => r.ToStationId)
            .OnDelete(DeleteBehavior.Restrict);


        var trip = modelBuilder.Entity<Entities.Trip>();

        trip.HasOne(t => t.Train)
            .WithMany(tr => tr.Trips)
            .HasForeignKey(t => t.TrainId)
            .OnDelete(DeleteBehavior.Restrict); 

        trip.HasOne(t => t.Driver)
            .WithMany(d => d.Trips)
            .HasForeignKey(t => t.DriverId)
            .OnDelete(DeleteBehavior.Restrict);

        trip.HasOne(t => t.Route)
            .WithMany(r => r.Trips)
            .HasForeignKey(t => t.RouteId)
            .OnDelete(DeleteBehavior.Restrict);

        trip.HasOne(t => t.TimeTable)
            .WithMany()
            .HasForeignKey(t => t.TimeTableId)
            .OnDelete(DeleteBehavior.Restrict);

        var ticket = modelBuilder.Entity<Entities.Ticket>();

        ticket.HasOne(t => t.Trip)
            .WithMany(tr => tr.Tickets) 
            .HasForeignKey(t => t.TripId)
            .OnDelete(DeleteBehavior.Restrict);

        ticket.HasOne(t => t.Company)
            .WithMany(c => c.Tickets)
            .HasForeignKey(t => t.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);

    }

}


