using System.Net.NetworkInformation;

namespace DesafioFinal.Repositories.Scripts
{
    public static class SQLScripts
    {
        public static string GetGeneric => @"
            SELECT * 
            FROM {Table}
            WHERE Id = @Id;
        ";

        public static string CountGeneric => @"
            SELECT Count(1)
            FROM {Table};
        ";

        public static string GetAllGeneric => @"
            SELECT *
            FROM {Table};
        ";
        public static string DeleteGeneric => @"
            DELETE
            FROM Clients
            WHERE Id = @Id;
        ";

        public static string GetClientByEmail => @"
            SELECT * 
            FROM Clients
            WHERE Email = @Email;
        ";

        public static string InsertClient => @"
            INSERT INTO Clients (Id, Email, Name, Phone, Address, City)
            VALUES (@Id, @Email, @Name, @Phone, @Address, @City);
        ";
        public static string UpdateClient => @"
            UPDATE Clients
            SET Name = @Name, Address = @Address  
            WHERE Id = @Id;
        ";
    }
}
