using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.ApplicationCore.Interface;




//Plane plane = new Plane();
//plane.Planetype = PlaneType.Boing;
//plane.Capacity = 200;
//plane.ManifacturalDate = new DateTime(2018, 11, 10);

//Console.WriteLine(plane.ToString());

// partie 2 

//Plane plane2 = new Plane(PlaneType.Boing , 300 , DateTime.Now);

//Console.WriteLine(plane2);

//3eme methode

Plane plane3 = new Plane { Planetype = PlaneType.Airbus, Capacity = 150, ManifacturalDate = new DateTime(2013,02,03)};
//lezim na7iw l constructeur 5ater naamlou f instanstation intutitive

Console.WriteLine(plane3);

//test CheckProfile


//Passenger passenger = new Passenger
//{
//    FirstName = "John",
//    LastName = "Doe",
//    EmailAddress = "john.doe@example.com"
//    // initialiser d'autres propriétés si nécessaire
//};

//// Appeler la méthode CheckProfile avec nom et prénom
//bool match1 = passenger.CheckProfile("Doe", "John");
//Console.WriteLine($"Match 1: {match1}");

//// Appeler la méthode CheckProfile avec nom, prénom et email
//bool match2 = passenger.CheckProfile("Doe", "John", "john.doe@example.com");
//Console.WriteLine($"Match 2: {match2}");

//Console.ReadKey();

Passenger p1 = new Passenger
    {
        FirstName = "John",
      LastName = "Doe",
       EmailAddress = "john.doe@example.com"
       
    };
//Console.WriteLine("la méthode checkpassenger");
//Console.WriteLine(p1.CheckProfile("John", "Doe"));
//Console.WriteLine(p1.CheckProfile("John", "Doe", "john.doe@example.com"));


Console.WriteLine("*************Testing passenger**************");
Staff s1= new Staff { FirstName = "Bill", LastName = "Gates", EmailAddress="BillGates@gmail.com" };
Traveller t1= new Traveller();
p1.PassengerType();
s1.PassengerType();
t1.PassengerType();



ServiceFlight sf = new ServiceFlight();
sf.Flights = TestData.listFlights;
bool test = false;
if (test)
{

}



