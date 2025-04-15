using CPSY200FinalProject.Components.Layout;
using MySqlConnector;

namespace CPSY200FinalProject.Components.Persistence;

public class WriteDatabase
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
    
    public static void writeCustomers(MySqlConnection connection, List<CustomerObj> customers)
    {
        string query0 =
            "DROP TABLE IF EXISTS customer"
        ;

        string query1 =
            "CREATE TABLE customer (customerID INT NOT NULL, firstName VARCHAR(255) NOT NULL, lastName VARCHAR(255) NOT NULL, phone INT NULL, email VARCHAR(255) NOT NULL, notes VARCHAR(255) NOT NULL);"
        ;
        
        MySqlCommand command0 = new MySqlCommand(query0, connection);   
        command0.ExecuteNonQuery();
            
        MySqlCommand command1 = new MySqlCommand(query1, connection);   
        command1.ExecuteNonQuery();

        int i = 0;
        foreach (var customer in customers)
        {
            i++; 
            string query2 =
                $"INSERT INTO customer VALUES({i}, '{customer.firstName}', '{customer.lastName}', {customer.phoneNumber}, '{customer.email}', '{customer.notes}')"
            ;
            
            MySqlCommand command2 = new MySqlCommand(query2, connection);   
            command2.ExecuteNonQuery();
        }
    }
    
    public static void writeEquipment(MySqlConnection connection, List<EquipmentObj> equipment)
    {
        string query0 =
            "DROP TABLE IF EXISTS equipment"
        ;

        string query1 =
            "CREATE TABLE equipment (equipmentID INT NOT NULL, category VARCHAR(255) NOT NULL, name VARCHAR(255) NOT NULL, description VARCHAR(255) NOT NULL, dailyRentalCost DOUBLE NOT NULL);"
        ;
        
        MySqlCommand command0 = new MySqlCommand(query0, connection);   
        command0.ExecuteNonQuery();
            
        MySqlCommand command1 = new MySqlCommand(query1, connection);   
        command1.ExecuteNonQuery();

        int i = 0;
        foreach (var e in equipment)
        {
            i++;
            string query2 =
                $"INSERT INTO equipment VALUES({i}, '{e.category}', '{e.name}', '{e.description}', {e.dailyRentalCost})"
            ;
            
            MySqlCommand command2 = new MySqlCommand(query2, connection);   
            command2.ExecuteNonQuery();
        }
    }
    
    public static void writeRentals(MySqlConnection connection, List<RentalObj> rentals)
    {
        string query0 =
            "DROP TABLE IF EXISTS rental"
        ;

        string query1 =
            "CREATE TABLE rental (rentalDate VARCHAR(255) NOT NULL, returnDate VARCHAR(255) NOT NULL, price DOUBLE NOT NULL, totalCost DOUBLE NULL);"
        ;
        
        MySqlCommand command0 = new MySqlCommand(query0, connection);   
        command0.ExecuteNonQuery();
            
        MySqlCommand command1 = new MySqlCommand(query1, connection);   
        command1.ExecuteNonQuery();
        
        foreach (var r in rentals)
        {
            string query2 =
                $"INSERT INTO rental VALUES('{r.rentalDate}', '{r.returnDate}', {r.price}, {r.totalCost})"
            ;
            
            MySqlCommand command2 = new MySqlCommand(query2, connection);   
            command2.ExecuteNonQuery();
        }
    }
}