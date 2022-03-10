using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using Smart_Assistant_Design.db;

namespace Smart_Assistant_Design.daily_plan
{
    public partial class Daily_Plan_Manager : Form
    {
        public Daily_Plan_Manager()
        {
            InitializeComponent();
            this.time_pick_field.Format = DateTimePickerFormat.Time;
            this.time_pick_field.ShowUpDown = true;
            // Colors.
            this.BackColor = Color.FromArgb(217, 187, 160);
            this.add_event.BackColor = Color.FromArgb(3, 88, 140);
            this.add_event.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.delete_event.BackColor = Color.FromArgb(3, 88, 140);
            this.delete_event.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.exit.BackColor = Color.FromArgb(3, 88, 140);
            this.exit.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date_pick_field.Value = calendar.SelectionStart.Date;
        }

        private void add_event_to_db()
        {
            Database.establishe_connection();
            String query = "INSERT INTO DailyPlan (date, RoomName, RoomType, Time) VALUES (@date, @eventname, @eventtype, @time)";
            SQLiteCommand insert_c = new SQLiteCommand(query, Database.get_connection());

            insert_c.Parameters.AddWithValue("date", date_pick_field.Value.Date.ToString());
            insert_c.Parameters.AddWithValue("eventname", event_name_field.Text.ToString());
            insert_c.Parameters.AddWithValue("eventtype", event_type_field.Text.ToString());
            insert_c.Parameters.AddWithValue("time", time_pick_field.Value.TimeOfDay.ToString());

            insert_c.ExecuteNonQuery();
            Database.close_connection();
        }

        private void add_event_click(object sender, System.EventArgs e)
        {
            if (event_name_field.Text.Equals("") ||
                event_type_field.Text.Equals(""))
            {
                MessageBox.Show("Please check that all the reuired fields are filled");
                return;
            }

            add_event_to_db();
        }

        private void remove_event_from_db()
        {
            Database.establishe_connection();

            String query = "DELETE FROM DailyPlan WHERE date=@date and " +
                           "RoomName=@eventname and RoomType=@eventtype and Time=@time";
            SQLiteCommand insert_c = new SQLiteCommand(query, Database.get_connection());
            insert_c.Parameters.AddWithValue("date", date_pick_field.Value.Date.ToString());
            insert_c.Parameters.AddWithValue("eventname", event_name_field.Text.ToString());
            insert_c.Parameters.AddWithValue("eventtype", event_type_field.Text.ToString());
            insert_c.Parameters.AddWithValue("time", time_pick_field.Value.TimeOfDay.ToString());

            insert_c.ExecuteNonQuery();
            Database.close_connection();
        }


        private void delete_event_click(object sender, System.EventArgs e)
        {
            if (event_name_field.Text.Equals("") ||
               event_type_field.Text.Equals(""))
            {
                MessageBox.Show("Please check that all the reuired fields are filled");
                return;
            }

            remove_event_from_db();
        }

        
    }
}
