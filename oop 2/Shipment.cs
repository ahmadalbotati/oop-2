class Shipment
{
    private string trackingCode = "Unknown";
    private string description = "Unknown";
    private decimal weight = 1;
    private decimal deliveryFee = 50;

    public string TrackingCode
    {
        get { return trackingCode; }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
        private set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    public DeliveryAddress Destination { get; set; }

    public virtual decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public Shipment(string trackingCode)
    {
        if (!string.IsNullOrWhiteSpace(trackingCode))
            this.trackingCode = trackingCode;

        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    }

    public Shipment(string trackingCode, string description, decimal weight,
        decimal deliveryFee, DeliveryAddress destination)
    {
        if (!string.IsNullOrWhiteSpace(trackingCode))
            this.trackingCode = trackingCode;

        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
        Destination = destination;
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
            DeliveryFee = newFee;
    }

    public void UpdateWeight(decimal newWeight)
    {
        if (newWeight > 0)
            Weight = newWeight;
    }

    public void UpdateWeight(decimal newWeight, decimal packingWeight)
    {
        if (newWeight > 0 && packingWeight >= 0)
            Weight = newWeight + packingWeight;
    }

    public virtual void PrintShipment()
    {
        Console.WriteLine("Tracking Code : " + TrackingCode);
        Console.WriteLine("Description   : " + Description);
        Console.WriteLine("Weight        : " + Weight);
        Console.WriteLine("Delivery Fee  : " + DeliveryFee);
        Console.WriteLine("Destination   : " + Destination.GetFullAddress());
        Console.WriteLine("Estimated Cost: " + EstimatedCost);
    }
}