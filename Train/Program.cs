using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using Train.DataAccess;
using Train.Entities;
namespace Train;

public class Program
{
    static void Main(string[] args)
    {
        using (var db = new TrainDbContext())
        {
            //var company = new Company
            //{
            //    Name = "TrainCo",
            //    FoundationYear = 1990,
            //    Email = "trainco@gmail.com",
            //    Phone = "1234567890",
            //    WebsiteUrl = "www.trainco.com",
            //    VOEN = "123456789"
            //};
            //db.Companies.Add(company);
            //db.SaveChanges();

            //var p1 = new Passanger
            //{
            //    Name = "John",
            //    Surname = "Doe",
            //    FIN = "ABC123456"
            //};
            //var p2 = new Passanger
            //{
            //    Name = "Jane",
            //    Surname = "Smith",
            //    FIN = "DEF654321"
            //};
            //var p3 = new Passanger
            //{
            //    Name = "Alice",
            //    Surname = "Johnson",
            //    FIN = "GHI789012"
            //};

            //db.Passangers.AddRange(p1, p2, p3);
            //db.SaveChanges();

            //var mr = new MedicalRecord
            //{
            //    BloodType = BloodType.A_Negative,
            //    VisionTestResult = 0.8,
            //    PsychologicalFitness = PsychologicalFitness.Well
            //};

            //var mr2 = new MedicalRecord
            //{
            //    BloodType = BloodType.B_Positive,
            //    VisionTestResult = 0.6,
            //    PsychologicalFitness = PsychologicalFitness.Good
            //};

            //var mr3 = new MedicalRecord
            //{
            //    BloodType = BloodType.O_Positive,
            //    VisionTestResult = 0.9,
            //    PsychologicalFitness = PsychologicalFitness.Poor
            //};

            //db.MedicalRecords.AddRange(mr, mr2, mr3);
            //db.SaveChanges();

            //var mc = new MedicalCertificate
            //{
            //    IssueDate = DateTime.Now,
            //    ExpiryDate = DateTime.Now.AddYears(1),
            //    MedicalRecord = mr
            //};

            //var mc2 = new MedicalCertificate
            //{
            //    IssueDate = DateTime.Now,
            //    ExpiryDate = DateTime.Now.AddYears(1),
            //    MedicalRecord = mr2
            //};

            //var mc3 = new MedicalCertificate
            //{
            //    IssueDate = DateTime.Now,
            //    ExpiryDate = DateTime.Now.AddYears(1),
            //    MedicalRecord = mr3
            //};

            //db.MedicalCertificates.AddRange(mc, mc2, mc3);
            //db.SaveChanges();

            //var wh = new WorkingHour
            //{
            //    StartTime = new DateTime(2024, 1, 1, 8, 0, 0),
            //    EndTime = new DateTime(2024, 1, 1, 16, 0, 0)
            //};

            //var wh2 = new WorkingHour
            //{
            //    StartTime = new DateTime(2024, 1, 2, 8, 0, 0),
            //    EndTime = new DateTime(2024, 1, 2, 16, 0, 0)
            //};
            //var wh3 = new WorkingHour
            //{
            //    StartTime = new DateTime(2024, 1, 3, 8, 0, 0),
            //    EndTime = new DateTime(2024, 1, 3, 16, 0, 0)
            //};

            //db.WorkingHours.AddRange(wh, wh2, wh3);
            //db.SaveChanges();

            //var wd = new WorkingDay
            //{
            //    Day = WeekDay.Monday,
            //};

            //var wd2 = new WorkingDay
            //{
            //    Day = WeekDay.Tuesday,
            //};

            //var wd3 = new WorkingDay
            //{
            //    Day = WeekDay.Wednesday,
            //};

            //db.WorkingDays.AddRange(wd, wd2, wd3);
            //db.SaveChanges();

            //var dr = new Driver
            //{
            //    Name = "Bob",
            //    Surname = "Brown",
            //    DadName = "Jack",
            //    Age = 41,
            //    SerialNo = "DR123456",
            //    Fin = "DRFIN123456",
            //    ProfilePicUrl = "www.trainco.com/drivers/bob.jpg",
            //    MedicalCertificate = mc,
            //    Company = company
            //};


            //var dr2 = new Driver
            //{
            //    Name = "Charlie",
            //    Surname = "Davis",
            //    DadName = "Tom",
            //    Age = 35,
            //    SerialNo = "DR654321",
            //    Fin = "DRFIN654321",
            //    ProfilePicUrl = "www.trainco.com/drivers/charlie.jpg",
            //    MedicalCertificate = mc2,
            //    Company = company
            //};


            //var dr3 = new Driver
            //{
            //    Name = "Eve",
            //    Surname = "Wilson",
            //    DadName = "Sam",
            //    Age = 29,
            //    SerialNo = "DR789012",
            //    Fin = "DRFIN789012",
            //    ProfilePicUrl = "www.trainco.com/drivers/eve.jpg",
            //    MedicalCertificate = mc3,
            //    Company = company
            //};

            //db.Drivers.AddRange(dr, dr2, dr3);
            //db.SaveChanges();


            //var ds = new DriverSchedule
            //{
            //    WorkingHour = wh,
            //    WorkingDay = wd,
            //    Driver = dr
            //};

            //var ds2 = new DriverSchedule
            //{
            //    WorkingHour = wh2,
            //    WorkingDay = wd2,
            //    Driver = dr2
            //};

            //var ds3 = new DriverSchedule
            //{
            //    WorkingHour = wh3,
            //    WorkingDay = wd3,
            //    Driver = dr3
            //};

            //db.DriverSchedules.AddRange(ds, ds2, ds3);
            //db.SaveChanges();


            //var pr = new Professionality
            //{
            //    ProfessionalLevel = ProfessionalLevel.Senior,
            //    WorkExperience = 15,
            //    LicenseNo = "PL123456",
            //    Driver = dr
            //};

            //var pr2 = new Professionality
            //{
            //    ProfessionalLevel = ProfessionalLevel.Middle,
            //    WorkExperience = 10,
            //    LicenseNo = "PL654321",
            //    Driver = dr2
            //};

            //var pr3 = new Professionality
            //{
            //    ProfessionalLevel = ProfessionalLevel.Junior,
            //    WorkExperience = 5,
            //    LicenseNo = "PL789012",
            //    Driver = dr3
            //};

            //db.Professionalities.AddRange(pr, pr2, pr3);
            //db.SaveChanges();

            //var dc = new Contact
            //{
            //    Driver = dr,
            //    Phone = "9876543210",
            //    Email = "drbobbrown@gmail.com"
            //};

            //var dc2 = new Contact
            //{
            //    Driver = dr2,
            //    Phone = "8765432109",
            //    Email = "charliedavis@gmail.com"
            //};

            //var dc3 = new Contact
            //{
            //    Driver = dr3,
            //    Phone = "7654321098",
            //    Email = "evewilson@gmail.com"
            //};

            //db.Contacts.AddRange(dc, dc2, dc3);
            //db.SaveChanges();

            //var ts = new TrainSpecification
            //{
            //    MaxSpeed = 200,
            //    CarriageType = CarriageType.Seater,
            //    FuelType = FuelType.Electric
            //};

            //var ts2 = new TrainSpecification
            //{
            //    MaxSpeed = 150,
            //    CarriageType = CarriageType.Sleeper,
            //    FuelType = FuelType.Diesel
            //};

            //var ts3 = new TrainSpecification
            //{
            //    MaxSpeed = 180,
            //    CarriageType = CarriageType.Dining,
            //    FuelType = FuelType.Hybrid
            //};

            //db.TrainSpecifications.AddRange(ts, ts2, ts3);
            //db.SaveChanges();

            //// basla 
            //var stBaku = new Station { StationName = "Bakı Vağzalı", LocationName = "Bakı", StationCode = 1001 };
            //var stGanja = new Station { StationName = "Gəncə Stansiyası", LocationName = "Gəncə", StationCode = 1002 };
            //var stGabala = new Station { StationName = "Qəbələ Vağzalı", LocationName = "Qəbələ", StationCode = 1003 };

            //var tt = new TimeTable { DeptureTime = DateTime.Now.AddHours(1), ArrivalTime = DateTime.Now.AddHours(5), DwellTime = DateTime.Now.AddMinutes(20) };
            //var tt2 = new TimeTable { DeptureTime = DateTime.Now.AddHours(6), ArrivalTime = DateTime.Now.AddHours(10), DwellTime = DateTime.Now.AddMinutes(15) };
            //var tt3 = new TimeTable { DeptureTime = DateTime.Now.AddHours(12), ArrivalTime = DateTime.Now.AddHours(16), DwellTime = DateTime.Now.AddMinutes(10) };

            //db.Stations.AddRange(stBaku, stGanja, stGabala);
            //db.TimeTables.AddRange(tt, tt2, tt3);
            //db.SaveChanges();

            //var wp = new WaitPoint { Distance = 10.5, IsRed = false };
            //var wp2 = new WaitPoint { Distance = 55.2, IsRed = true };
            //var wp3 = new WaitPoint { Distance = 120.8, IsRed = false };

            //db.WaitPoints.AddRange(wp, wp2, wp3);
            //db.SaveChanges();

            //var tse = new TrackSegment { SwitchDirection = SwitchDirection.Straight, WaitPoint = wp, IsOccupied = false };
            //var tse2 = new TrackSegment { SwitchDirection = SwitchDirection.Left, WaitPoint = wp2, IsOccupied = true };
            //var tse3 = new TrackSegment { SwitchDirection = SwitchDirection.Right, WaitPoint = wp3, IsOccupied = false };

            //db.TrackSegments.AddRange(tse, tse2, tse3);
            //db.SaveChanges();

            //var route = new Route { FromStation = stBaku, ToStation = stGanja, TimeTable = tt, IsBackward = false };
            //var route2 = new Route { FromStation = stGanja, ToStation = stGabala, TimeTable = tt2, IsBackward = false };
            //var route3 = new Route { FromStation = stGabala, ToStation = stBaku, TimeTable = tt3, IsBackward = true };

            //db.Routes.AddRange(route, route2, route3);
            //db.SaveChanges();

            //var path = new RoutePath { Route = route, TrackSegment = tse };
            //var path2 = new RoutePath { Route = route2, TrackSegment = tse2 };
            //var path3 = new RoutePath { Route = route3, TrackSegment = tse3 };


            //db.RoutePaths.AddRange(path, path2, path3);
            //db.SaveChanges();

            //var t = new Entities.Train
            //{
            //    ModelName = "Express",
            //    Status = TrainStatus.OnTime,
            //    Company = company,
            //    TrainSpecification = ts,
            //    Drivers = { dr, dr2 }

            //};

            //var t2 = new Entities.Train
            //{
            //    ModelName = "Regional",
            //    Status = TrainStatus.Scheduled,
            //    Company = company,
            //    TrainSpecification = ts2,
            //    Drivers = { dr2, dr3 }
            //};


            //var t3 = new Entities.Train
            //{
            //    ModelName = "Intercity",
            //    Status = TrainStatus.Delayed,
            //    Company = company,
            //    TrainSpecification = ts3,
            //    Drivers = { dr, dr3 }
            //};

            //db.Trains.AddRange(t, t2, t3);
            //db.SaveChanges();



            //var wg = new Wagon
            //{
            //    SeatCount = 50,
            //    Train = t,
            //    WagonNo = 1
            //};

            //wg.Seats = new List<Seat>()
            //{
            //    new Seat { Passanger = p2, Wagon = wg, SeatNo = 2 },
            //    new Seat { Passanger = p3, Wagon = wg, SeatNo = 3 },
            //    new Seat { Passanger = null, Wagon = wg, SeatNo = 4 },
            //    new Seat { Passanger = null, Wagon = wg, SeatNo = 5 },
            //    new Seat { Passanger = null, Wagon = wg, SeatNo = 6 }
            //};

            //var wg2 = new Wagon
            //{
            //    SeatCount = 40,
            //    Train = t2,
            //    WagonNo = 2
            //};

            //wg2.Seats = new List<Seat>()
            //{
            //    new Seat { Passanger = p1, Wagon = wg2, SeatNo = 1 },
            //    new Seat { Passanger = null, Wagon = wg2, SeatNo = 2 },
            //    new Seat { Passanger = null, Wagon = wg2, SeatNo = 3 },
            //    new Seat { Passanger = null, Wagon = wg2, SeatNo = 4 },
            //    new Seat { Passanger = null, Wagon = wg2, SeatNo = 5 }
            //};

            //var wg3 = new Wagon
            //{
            //    SeatCount = 30,
            //    Train = t3,
            //    WagonNo = 3
            //};

            //wg3.Seats = new List<Seat>()
            //{
            //    new Seat { Passanger = null, Wagon = wg3, SeatNo = 1 },
            //    new Seat { Passanger = null, Wagon = wg3, SeatNo = 2 },
            //    new Seat { Passanger = null, Wagon = wg3, SeatNo = 3 },
            //    new Seat { Passanger = null, Wagon = wg3, SeatNo = 4 },
            //    new Seat { Passanger = null, Wagon = wg3, SeatNo = 5 }
            //};

            //db.Wagons.AddRange(wg, wg2, wg3);
            //db.SaveChanges();




            //var trip1 = new Trip { Train = t, Driver = dr, Route = route, TimeTable = tt };
            //var trip2 = new Trip { Train = t2, Driver = dr2, Route = route2, TimeTable = tt2 };
            //var trip3 = new Trip { Train = t3, Driver = dr3, Route = route3, TimeTable = tt3 };

            //db.Trips.AddRange(trip1, trip2, trip3);
            //db.SaveChanges();
            ////-- bitib 


            //var ticket1 = new Ticket
            //{
            //    Price = 15.50,
            //    TripStatus = TicketStatus.Sold,
            //    Company = company,
            //    Passanger = p1,
            //    Trip = trip1,
            //    Seat = (wg.Seats as List<Seat>)[0]
            //};

            //var ticket2 = new Ticket
            //{
            //    Price = 25.00,
            //    TripStatus = TicketStatus.Sold,
            //    Company = company,
            //    Passanger = p2,
            //    Trip = trip2,
            //    Seat = (wg2.Seats as List<Seat>)[0]
            //};

            //var ticket3 = new Ticket
            //{
            //    Price = 10.20,
            //    TripStatus = TicketStatus.Available,
            //    Company = company,
            //    Passanger = p3,
            //    Trip = trip3,
            //    Seat = (wg3.Seats as List<Seat>)[0]
            //};

            //db.Tickets.AddRange(ticket1, ticket2, ticket3);
            //db.SaveChanges();


            var process = new Process();
            process.ShowTrips(db);
            int tripId;
            try
            {
                tripId = process.GetPassangerChoice(db);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
          
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }
            process.ShowTickets(db, tripId);


        }
    }
}
