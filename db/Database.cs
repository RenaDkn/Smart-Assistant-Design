using Microsoft.Data.Sqlite;
using Smart_Assistant_Design.daily_plan;
using System;


namespace Smart_Assistant_Design.db
{
    public class Database
    {
        private static SqliteConnection conn;

        public static void establishe_connection() 
        {
            // Establishe a new connection.
        }

        public static SqliteConnection get_connection()
        {
            return Database.conn;
        }

        public static Daily_Plan_Type get_plan_type(String plan_name, DateTime date, DateTime time)
        {
            // Use the connection above to get the 
            return Daily_Plan_Type.DATE; 
        }
    }
}
