using System;

class Program
{
    static void Main()
    {
        DeliveryCenter center = new DeliveryCenter();

        Console.Write("Center Name: ");
        center.CenterName = Console.ReadLine() ?? "Unknown";

        Console.WriteLine("\nStandard Shipment");

        Console.Write("Tracking Code: ");
        string tracking1 = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        string description1 = Console.ReadLine() ?? "";

        Console.Write("Weight: ");
        decimal weight1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Delivery Fee: ");
        decimal fee1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("City: ");
        string city1 = Console.ReadLine() ?? "";

        Console.Write("Street: ");
        string street1 = Console.ReadLine() ?? "";

        Console.Write("Building Number: ");
        int building1 = Convert.ToInt32(Console.ReadLine());

        DeliveryAddress address1 =
            new DeliveryAddress(city1, street1, building1);

        StandardShipment standard =
            new StandardShipment(
                tracking1, description1, weight1, fee1, address1);


        Console.WriteLine("\nExpress Shipment");

        Console.Write("Tracking Code: ");
        string tracking2 = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        string description2 = Console.ReadLine() ?? "";

        Console.Write("Weight: ");
        decimal weight2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Delivery Fee: ");
        decimal fee2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("City: ");
        string city2 = Console.ReadLine() ?? "";

        Console.Write("Street: ");
        string street2 = Console.ReadLine() ?? "";

        Console.Write("Building Number: ");
        int building2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Extra Fee: ");
        decimal extraFee = Convert.ToDecimal(Console.ReadLine());

        DeliveryAddress address2 =
            new DeliveryAddress(city2, street2, building2);

        ExpressShipment express =
            new ExpressShipment(
                tracking2, description2, weight2, fee2, address2, extraFee);


        Console.WriteLine("\nInternational Shipment");

        Console.Write("Tracking Code: ");
        string tracking3 = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        string description3 = Console.ReadLine() ?? "";

        Console.Write("Weight: ");
        decimal weight3 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Delivery Fee: ");
        decimal fee3 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("City: ");
        string city3 = Console.ReadLine() ?? "";

        Console.Write("Street: ");
        string street3 = Console.ReadLine() ?? "";

        Console.Write("Building Number: ");
        int building3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Country: ");
        string country = Console.ReadLine() ?? "";

        Console.Write("Customs Fee: ");
        decimal customsFee = Convert.ToDecimal(Console.ReadLine());

        DeliveryAddress address3 =
            new DeliveryAddress(city3, street3, building3);

        InternationalShipment international =
            new InternationalShipment(
                tracking3, description3, weight3, fee3,
                address3, country, customsFee);


        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);

        Console.WriteLine("\nAll Shipments");
        center.PrintAllShipments();

        Console.Write("\nEnter Tracking Code to Search: ");
        string searchCode = Console.ReadLine() ?? "";

        Shipment found = center[searchCode];

        if (found != null)
            found.PrintShipment();
        else
            Console.WriteLine("Shipment not found.");

        Console.Write("\nEnter Tracking Code to Remove: ");
        string removeCode = Console.ReadLine() ?? "";

        if (center.RemoveShipment(removeCode))
            Console.WriteLine("Shipment removed.");
        else
            Console.WriteLine("Shipment not found.");

        Console.WriteLine("\nRemaining Shipments");
        center.PrintAllShipments();
    }
}