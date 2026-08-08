class InternationalShipment : Shipment
{
    public string DestinationCountry { get; set; }
    public decimal CustomsFee { get; set; }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5) + CustomsFee; }
    }

    public InternationalShipment(string trackingCode, string description,
        decimal weight, decimal deliveryFee, DeliveryAddress destination,
        string destinationCountry, decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }
}