using Microsoft.Data.Sqlite;

namespace TODO_List;

public class Database
{
    public void CheckDatabase()
    {
        Console.WriteLine("Checking database...");
        if (File.Exists("database.db"))
        {
            Console.WriteLine("Database exists!");
        }
        else
        {
            CreateDatabase();
        }
    }

    private void CreateDatabase()
    {
        Console.WriteLine("Creating database...");
        try
        {
            using (var connection = new SqliteConnection($"Data Source=database.db;"))
            {
                connection.Open();
                Console.WriteLine("Database created!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error creating database!");
            Console.WriteLine(ex.Message);
        }

    }
}