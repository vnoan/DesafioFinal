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

        public static string GetClientByEmail => @"
            SELECT * 
            FROM Clients
            WHERE Email = @Email;
        ";
    }
}
