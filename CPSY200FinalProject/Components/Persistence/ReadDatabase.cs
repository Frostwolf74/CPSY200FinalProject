using CPSY200FinalProject.Components.Layout;
using MySqlConnector;

namespace CPSY200FinalProject.Components.Persistence;

public class ReadDatabase
{
    public static MySqlConnection databaseConfig()
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Database = "CPSY200FinalProject",
            UserID = "root",
            Password = "password"
        };
    
        MySqlConnection connection = new MySqlConnection(builder.ToString());
        connection.Open();

        return connection;
    }
    
    public static List<CustomerObj> readCustomers(MySqlConnection connection)
    {
        string query = 
            "SELECT * FROM customer"
        ;
        
        MySqlCommand command = new MySqlCommand(query, connection);
        List<CustomerObj> customers = new();
        
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                string firstName = reader.GetString("firstName");
                string lastName = reader.GetString("lastName");
                int phoneNumber = reader.GetInt32("phone");
                string email = reader.GetString("email");
                string notes = reader.GetString("notes");
                
                customers.Add(new CustomerObj(firstName, lastName, email, notes, phoneNumber));
            }
        }
        
        return customers;
    }
    
    public static List<EquipmentObj> readEquipment(MySqlConnection connection)
    {
        string query = 
            "SELECT * FROM equipment"
        ;
        
        MySqlCommand command = new MySqlCommand(query, connection);
        List<EquipmentObj> equipment = new();
        
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                string category = reader.GetString("category");
                string name = reader.GetString("name");
                string description = reader.GetString("description");
                double dailyRentalCost = reader.GetDouble("dailyRentalCost");
                
                equipment.Add(new EquipmentObj(category, name, description, dailyRentalCost));
            }
        }
        
        return equipment;
    }
    
    public static List<RentalObj> readRentals(MySqlConnection connection)
    {
        string query = 
            "SELECT * FROM rental"
        ;
        
        MySqlCommand command = new MySqlCommand(query, connection);
        List<RentalObj> rentals = new();
        
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                string rentalDate = reader.GetString("rentalDate");
                string returnDate = reader.GetString("returnDate");
                double price = reader.GetDouble("price");
                double totalCost = reader.GetDouble("totalCost");
                
                rentals.Add(new RentalObj(rentalDate, returnDate, price, totalCost));
            }
        }
        
        return rentals;
    }
}