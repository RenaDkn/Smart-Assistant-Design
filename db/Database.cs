using System.Data.SQLite;
using Smart_Assistant_Design.daily_plan;
using Smart_Assistant_Design.smart_lights;
using System;
using System.Windows.Forms;
using Smart_Assistant_Design.smart_shoe_rack;

namespace Smart_Assistant_Design.db
{
    public class Database
    {
        private static SQLiteConnection conn;

        public static void establishe_connection()
        {
            string connectionString = @"Data Source=C:\Users\rounnus\Documents\github\Smart-Assistant-Design\database\database1.db;Version=3;";
            try
            {
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            // Establishe a new connection.
        }
        public static void close_connection()
        {
            conn.Close();
        }
        public static SQLiteConnection get_connection()
        {
            return Database.conn;
        }
        public static string return_lights(string room)
        {
            SQLiteCommand command;
            SQLiteDataReader reader;
            String query = "SELECT * FROM Rooms";
            String lights = " ";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader.GetValue(0) == room)
                {
                    lights = (string)reader.GetValue(2);

                }
            }
            reader.Close();
            close_connection();
            return lights;
        }
        public static string return_image(string room)
        {
            SQLiteCommand command;
            SQLiteDataReader reader;
            String query = "SELECT * FROM Rooms";
            String image = " ";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader.GetValue(0) == room)
                {
                    image = (string)reader.GetValue(1);
                }
            }
            close_connection();
            return image;
        }
        public static void save_lights(string room, string lights)
        {
            SQLiteCommand command;
            String query = "UPDATE Rooms SET Lights=@lights WHERE RoomName=@room ";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            command.Parameters.AddWithValue("@room", room);
            command.Parameters.AddWithValue("@lights", lights);
            command.ExecuteNonQuery();
            close_connection();

        }
        public static Shoes watch_next_shoes(int count)
        {
            int cnt = 1;
            Shoes s1 = new Shoes();
            SQLiteCommand command;
            SQLiteDataReader reader;
            String query = "SELECT * FROM ShoeRack";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (cnt == count)
                {
                    s1.SetNickname((string)reader.GetValue(0));
                    s1.SetImage((string)reader.GetValue(1));
                    s1.SetAttributes((string)reader.GetValue(2));
                    s1.SetIndex((string)reader.GetValue(3));
                }
                cnt += 1;
            }
            close_connection();
            return s1;
        }
        public static int search_shoes(string nickname, string attributes)
        {
            int count = 0;
            int cnt = 1;
            SQLiteCommand command;
            SQLiteDataReader reader;
            String query = "SELECT * FROM ShoeRack";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (nickname == reader.GetValue(0).ToString())
                {
                    count = cnt;
                }
                cnt += 1;
            }
            close_connection();
            return count;
        }
        public static void delete_shoes(string nickname, string attributes)
        {

            int f = 1;
            SQLiteCommand command;
            SQLiteDataReader reader;
            string query = "SELECT * FROM ShoeRack";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (nickname == reader.GetValue(0).ToString())
                {
                    f = 0;
                    break;
                }
                else
                {
                    f = 1;
                }
            }
            reader.Close();
            close_connection();
            if (f == 0)
            {
                query = "DELETE FROM ShoeRack WHERE Nickname =@nickname";
                establishe_connection();
                command = new SQLiteCommand(query, get_connection());
                command.Parameters.AddWithValue("@nickname", nickname);
                command.ExecuteReader();
                close_connection();
                MessageBox.Show("Η διαγραφή έγινε επιτυχώς!");
            }
            else
            {//ean den uparxei asthenis me auto to onoma
                MessageBox.Show("Η διαγραφή δεν πραγματοποιηθηκε επιτυχώς διοτι δεν υπαρχει παπούτσι με αυτο το nickname!");
            }

        }
        public static void insert_shoes(string nickname,string index, string attributes)
        {
            SQLiteCommand command;
            string query = "INSERT INTO ShoeRack(Nickname, Image, Attributes, Ind)VALUES(@nickname,@image, @attributes, @index)";
            establishe_connection();
            command = new SQLiteCommand(query, get_connection());
            command.Parameters.AddWithValue("@nickname", nickname);
            command.Parameters.AddWithValue("@image", "null");
            command.Parameters.AddWithValue("@attributes", attributes);
            command.Parameters.AddWithValue("@index", index);
            command.ExecuteNonQuery();
            close_connection();
        }

        public static Daily_Plan_Type get_plan_type(String plan_name, DateTime date, DateTime time)
        {
            // Use the connection above to get the 
            return Daily_Plan_Type.DATE;
        }
    }
}

