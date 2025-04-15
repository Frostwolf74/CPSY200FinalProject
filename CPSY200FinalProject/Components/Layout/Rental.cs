namespace CPSY200FinalProject.Components.Layout;

public class Rental
{
    private string RentalDate { get; set; }
    private string ReturnDate { get; set; }
    private double price { get; set; }
    private double totalCost { get; set; }

    public Rental(string RentalDate, string ReturnDate, double price, double totalCost)
    {
        this.RentalDate = RentalDate;
        this.ReturnDate = ReturnDate;
        this.price = price;
        this.totalCost = totalCost;
    }
}