namespace CPSY200FinalProject.Components.Layout;

public class CustomerObj
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string notes { get; set; }
    public int? phoneNumber { get; set; }
    public bool selected { get; set; } // for adding and removing

    public CustomerObj(string firstName, string lastName, string email, string notes, int? phoneNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.notes = notes;
        this.phoneNumber = phoneNumber;
    }
}