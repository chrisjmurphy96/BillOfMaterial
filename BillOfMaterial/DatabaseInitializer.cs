using Microsoft.Data.Sqlite;

namespace BillOfMaterial;

public static class DatabaseInitializer
{
    public static void Initialize()
    {
        using SqliteConnection connection = new("Data Source=bill-of-material.db");
        connection.Open();
        using SqliteTransaction transaction = connection.BeginTransaction();
        using SqliteCommand command = connection.CreateCommand();
        // I'm making Quantity REAL in case of something like "0.5 yards of turf".
        command.CommandText = """
            CREATE TABLE IF NOT EXISTS BoMLevel (
                PrimaryKey INTEGER PRIMARY KEY,
                PartNumber TEXT,
                Quantity REAL,
                Unit TEXT,
                TotalCost REAL,
                Vendor TEXT,
                Type TEXT,
                Cost REAL,
                QuantityOnHand REAL,
                ReferenceKey INTEGER)
            """;
        command.ExecuteNonQuery();
        transaction.Commit();
    }
}
