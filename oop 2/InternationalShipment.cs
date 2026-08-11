class InternationalShipment : Shipment
{
    public string DestinationCountry { get; set; } = "Unknown";
    public decimal CustomsFee { get; set; } 

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5) + CustomsFee; }
    }

    public InternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry,
        decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        if (!string.IsNullOrWhiteSpace(destinationCountry))
            DestinationCountry = destinationCountry;

        if (customsFee >= 0)
            CustomsFee = customsFee;
    }

    public override void PrintShipment()
    {
        Console.WriteLine("International Shipment");
        base.PrintShipment();
        Console.WriteLine("Destination Country : " + DestinationCountry);
        Console.WriteLine("Customs Fee         : " + CustomsFee);
    }

    public virtual void GenerateCustomsReport()
    {
        Console.WriteLine("Customs Report Generated");
    }
}