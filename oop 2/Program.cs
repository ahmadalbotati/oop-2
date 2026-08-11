using System;

class Program
{
    static void Main()
    {
        Driver driver = new Driver("D001", "Ahmad Hassan", "01012345678");

        DeliveryCenter center = new DeliveryCenter();
        center.CenterName = "Main Center";
        center.Driver = driver;

        DeliveryAddress address1 =
            new ("Cairo", "Nasr City", 10);

        DeliveryAddress address2 =
            new("Giza", "Dokki", 20);

        DeliveryAddress address3 =
            new ("Cairo", "Maadi", 30);

        StandardShipment standard =
            new ("SH001", "Laptop", 3, 80, address1);

        ExpressShipment express =
            new ("SH002", "Mobile Phone", 2, 60, address2, 30);

        InternationalShipment international =
            new ("SH003", "Television", 8, 120,
                address3, "Germany", 100);

        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);

        Console.WriteLine("Delivery Center");
        Console.WriteLine("Driver : " + center.Driver.FullName);

        center.PrintAllShipments();

        Console.WriteLine("Printing Using DeliveryHelper...");

        DeliveryHelper.PrintShipmentDetails(standard);
        Console.WriteLine("Standard Shipment Printed Successfully.");

        DeliveryHelper.PrintShipmentDetails(express);
        Console.WriteLine("Express Shipment Printed Successfully.");

        DeliveryHelper.PrintShipmentDetails(international);
        Console.WriteLine("International Shipment Printed Successfully.");

        Console.WriteLine("Updating Weight...");

        Console.WriteLine("Original Weight : " + standard.Weight + " KG");

        standard.UpdateWeight(5);
        Console.WriteLine("Updated Weight : " + standard.Weight + " KG");

        standard.UpdateWeight(5, 0.5m);
        Console.WriteLine("Updated Weight After Packing : " + standard.Weight + " KG");

        Console.WriteLine("Printing Using Shipment[]...");

        Shipment[] shipments =
        {
            standard,
            express,
            international
        };

        foreach (Shipment shipment in shipments)
        {
            shipment.PrintShipment();
        }

        Console.WriteLine("Sealed Class and Method Demo");

        CompletedShipment completed =
            new(
                "SH004",
                "Completed Package",
                4,
                70,
                new DeliveryAddress("Cairo", "Heliopolis", 15));

        completed.PrintShipment();

        PriorityInternationalShipment priority =
            new (
                "SH005",
                "Priority Package",
                6,
                150,
                new DeliveryAddress("Cairo", "Zamalek", 25),
                "France",
                120);

        priority.GenerateCustomsReport();
    }
}