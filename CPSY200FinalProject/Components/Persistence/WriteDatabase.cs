using CPSY200FinalProject.Components.Layout;

namespace CPSY200FinalProject.Components.Persistence;
using MySqlConnector;

public class WriteDatabase
{
    public static void write(List<CustomerObj> customers)
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

        foreach (var customer in customers)
        {
            string query =
                $"INSERT INTO customers VALUES('{customer.firstName}', '{customer.lastName}', {customer.phoneNumber}, '{customer.email}', '{customer.notes}')"
            ;
        
            MySqlCommand command = new MySqlCommand(query, connection);   
            command.ExecuteNonQuery();
        }
    }
}