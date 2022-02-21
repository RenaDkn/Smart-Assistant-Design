using Microsoft.Data.Sqlite;
using Smart_Assistant_Design.daily_plan;
using System;
using System.Windows.Forms;

namespace Smart_Assistant_Design.db
{
    public class Database
    {
        private static SqliteConnection conn;
       
        public static void establishe_connection() 
        {
            string connectionString = @"Data Source=C:\Users\Rena Dikonimaki\Documents\GitHub\Smart-Assistant-Design\database\;Version=3;";
        
            try
            {
                conn = new SqliteConnection(connectionString);
                conn.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        // Establishe a new connection.
        }
        public static void close_connection()
        {
            conn.Close();
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
