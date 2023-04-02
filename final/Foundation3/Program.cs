namespace Foundation3;

class Program {
    static void Main(string[] args) {
        
        Address address1 = new Address("2842 Happy St", "Richland", "WA", "99352");
        Address address2 = new Address("48 S Elk St", "Calgary", "AB", "5H45S");
        Address address3 = new Address("80047-2478 Posty Rd", "Los Angels", "CA", "47892");
        
        Lecture lecture = new Lecture("Lecture on Intelligence", "A lecture on the beginning of Intelligence", new DateTime(2023, 3, 23), new TimeSpan(2, 30, 0), address2, "President Nelson", 3000);
        Reception reception = new Reception("Wedding!", "Reception for Keaton and Lauren Davis", new DateTime(2023, 5, 20), new TimeSpan(2, 0, 0), address3, "RSVPKeatonDavis@gamil.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Church Activity", "Trunk or Treat put on by the church", new DateTime(2022, 2, 1), new TimeSpan(1, 30, 0), address1, "Cloudy With Rain");

        Console.WriteLine("\n-------------------------LECTURE DETAILS-------------------------");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n-------------------------RECEPTION DETAILS-------------------------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n-------------------------OUTDOOR GATHERING DETAILS-------------------------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
