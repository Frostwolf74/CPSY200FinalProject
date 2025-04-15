namespace CPSY200FinalProject.Components.Layout;

public class EquipmentObj
{
    public string category { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double dailyRentalCost { get; set; }
    public bool selected { get; set; } // for adding and removing

    public EquipmentObj(string category, string name, string description, double dailyRentalCost)
    {
        this.category = category;
        this.name = name;
        this.description = description;
        this.dailyRentalCost = dailyRentalCost;
    }
}