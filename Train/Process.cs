using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using Train.DataAccess;
using Train.Entities;

namespace Train;

public class Process
{
    public void ShowTrips(TrainDbContext db)
    {
        var trips =  db.Trips
                                  .Include(t => t.Route)
                                  .ThenInclude(r => r.FromStation)
                                  .Include(t => t.Route)
                                  .ThenInclude(r => r.ToStation)
                                  .ToList();

                                  
        Console.WriteLine("----------TRIPS------------");
        foreach (var t in trips)
        {
            Console.WriteLine($"{t.Id} \t{t.Route.FromStation.LocationName} - {t.Route.ToStation.LocationName}");
        }
    }

    public void ShowTickets(TrainDbContext db, int tripId)
    {
        var tickets = db.Tickets
            .Include(t => t.Company)
            .Include(t => t.Seat)
            .Include(t => t.Trip)
                .ThenInclude(tr => tr.Route)
                    .ThenInclude(r => r.FromStation)
            .Include(t => t.Trip)
                .ThenInclude(tr => tr.Route)
                    .ThenInclude(r => r.ToStation)
            .Where(t => t.TripId == tripId && t.TripStatus == TicketStatus.Available) 
            .ToList();

        if (!tickets.Any())
        {
            Console.WriteLine($"No available tickets for trip with id {tripId}");
            return;
        }

        Console.WriteLine("---------- AVAILABLE TICKETS ------------");
        Console.WriteLine("ID \t Price \t Seat \t Route \t Company");

        foreach (var t in tickets)
        {
            string routeInfo = $"{t.Trip.Route.FromStation.LocationName} -> {t.Trip.Route.ToStation.LocationName}";

            Console.WriteLine($"{t.Id} \t {t.Price} AZN \t {t.Seat?.SeatNo} \t {routeInfo} \t {t.Company?.Name}");
        }
    }


    public int GetPassangerChoice(TrainDbContext db)
    {
        Console.WriteLine($"Please select trip that you want.");
        string? choice = Console.ReadLine();
        if (string.IsNullOrEmpty(choice) || string.IsNullOrWhiteSpace(choice))
        {
            throw new ArgumentException("Invalid input. Please enter a valid trip ID.");
        }
        else if (!int.TryParse(choice, out int tripId))
        {
            throw new FormatException("Invalid input. Please enter a valid trip ID.");

        }
        else if (int.Parse(choice) <= 0 || int.Parse(choice) > db.Trips.Count())
        {
            throw new ArgumentOutOfRangeException("Invalid input. Please enter a valid trip ID.");
        }
        return int.Parse(choice);
    }

    }

