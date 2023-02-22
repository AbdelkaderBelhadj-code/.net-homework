using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; }
        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> ls = new List<DateTime>();
        //    //for (int i = 0; i < Flights.Count; i++)
        //    //{
        //    //    if (Flights[i].Destination == destination)
        //    //    {
        //    //        ls.Add(Flights[i].FlightDate);
        //    //    }
        //    //}
        //    //return ls;
        //    foreach (var flight in Flights)
        //    {
        //        if (flight.Destination == destination)
        //        {
        //            ls.Add(flight.FlightDate);
        //        }
        //    }

        //    return ls;
        //}
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination.Equals(filterValue))
                            Console.WriteLine(f.ToString());
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))
                            Console.WriteLine(f.ToString());
                    }
                    break;
                case "EffectiveArrival":
                    foreach (Flight f in Flights)
                    {
                        if (f.EffectiveArrival == DateTime.Parse(filterValue))
                            Console.WriteLine(f.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("choix erronée");
                    break;


            }

                    
            
        }
        public List<DateTime> GetFlightDates(string destination)
        {

            List<DateTime> ls = new List<DateTime>();
            var query = from flight in Flights
                        where flight.Destination.Equals(destination)
                        select flight.FlightDate;
            return query.ToList();
            //var query2 = Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate);
            //return query2.ToList();

        }
        public void showFlightDetails(Plane plane)
        {
            var query = from flight in Flights
                        where flight.Plane == plane
                        select new
                        {
                            flight.Destination,
                            flight.FlightDate
                            
                        };
            var query2 = Flights.Where(f=>f.Plane== plane).Select(f => new { f.Destination , f.FlightDate});
            foreach( var f in query2)
            {
                Console.WriteLine("destination = " + f.Destination + "flightdate" + f.FlightDate);
            }
        }

    }
}
