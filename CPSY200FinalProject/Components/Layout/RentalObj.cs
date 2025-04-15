namespace CPSY200FinalProject.Components.Layout;

public class RentalObj
{
    public string rentalDate { get; set; }
    public string returnDate { get; set; }
    public double? price { get; set; }
    public double? totalCost { get; set; }
    public bool selected { get; set; }

    public RentalObj(string rentalDate, string returnDate, double? price, double? totalCost)
    {
        this.rentalDate = rentalDate;
        this.returnDate = returnDate;
        this.price = price;
        this.totalCost = totalCost;
    }
}