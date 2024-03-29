﻿using Smart_Assistant_Design.smart_broom.status;
using Smart_Assistant_Design.smart_broom.rooms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SQLite;
using Smart_Assistant_Design.db;

namespace Smart_Assistant_Design.smart_broom
{
    enum DB_action
    {
        ADD,
        REMOVE
    }

    public partial class Smart_Broom_Control : Form
    {
        private Smart_Broom smart_broom;
        private DB_action action;

        public Smart_Broom_Control()
        {
            InitializeComponent();
            this.smart_broom = new Smart_Broom();
            this.BackColor = Color.FromArgb(217, 187, 160);
            this.start_cleaning.BackColor = Color.FromArgb(3, 88, 140);
            this.start_cleaning.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.stop_cleaning.BackColor = Color.FromArgb(3, 88, 140);
            this.stop_cleaning.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.add_room.BackColor = Color.FromArgb(3, 88, 140);
            this.add_room.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.remove_room.BackColor = Color.FromArgb(3, 88, 140);
            this.remove_room.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.add_rm_room_input.BackColor = Color.FromArgb(3, 88, 140);
            this.add_rm_room_input.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.exit.BackColor = Color.FromArgb(3, 88, 140);
            this.exit.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
        }

        private void refresh_control_panel()
        {
            // Refresh presentage label.
            this.presentage.Text = smart_broom.Presentage.ToString() + " %";
            // Refresh status label.
            this.status.Text = (smart_broom.Status == Broom_Status.SLEEP) ? "sleep" : 
                                (smart_broom.Status == Broom_Status.IN_PROCESS)? "in progress": "charging";
            // Refresh task queue.
            this.task_queue.Items.Clear();

            foreach (Room_To_Clean curr_room in 
                     smart_broom.get_rooms_to_clean())
            {
                this.task_queue.Items.Add(curr_room.Room);
            }

        }

        private void control_refresh_tick(object sender, EventArgs e)
        {
            // Refresh control panel every 1.5 seconds.
            this.refresh_control_panel();
        }

        private void battery_charge_tick(object sender, EventArgs e)
        {
            // Charge the battery of the broom. The battery will start charging if the broom is on base.
            if (smart_broom.Status == Broom_Status.CHARGING)
            {
                if (smart_broom.Presentage == 100)
                    smart_broom.Status = Broom_Status.SLEEP;
                else
                    smart_broom.Presentage += 2;
            }
        }

        private void battery_life_tick(object sender, EventArgs e)
        {
            // Decrease the battery of the broom while is working.
            if (smart_broom.Status == Broom_Status.IN_PROCESS)
            {
                if (smart_broom.Presentage < 15)
                    this.stop_cleaning_click(null, null);
                else
                    smart_broom.Presentage -= 2;
            }
               
        }

        private void start_cleaning_click(object sender, EventArgs e)
        {
            // If there is no rooms to clean in the queue.
            if (smart_broom.get_rooms_to_clean().Count == 0)
            {
                MessageBox.Show("Unable to start, no room has been selected.");
                return;
            }
            // Otherwise give the order to start the broom.
            smart_broom.Status = Broom_Status.IN_PROCESS;
        }

        private void stop_cleaning_click(object sender, EventArgs e)
        {
            // Check the state of the broom.
            if (smart_broom.Status == Broom_Status.SLEEP ||
                smart_broom.Status == Broom_Status.CHARGING)
            {
                MessageBox.Show("The broom is already stoped.");
            }

            if (smart_broom.Presentage < 100)
                smart_broom.Status = Broom_Status.CHARGING;
            else
                smart_broom.Status = Broom_Status.SLEEP;
        }

        private void task_queue_add_room(object sender, ItemCheckEventArgs e)
        {
            /*// If uncheck remove from queue.
            if (((CheckedListBox) sender).GetItemCheckState(e.Index) == CheckState.Unchecked)
            {
                foreach (Room_To_Clean curr_room in
                         smart_broom.get_rooms_to_clean())
                {
                    if (curr_room.Room.Equals(((CheckedListBox)sender).Items[e.Index]))
                        smart_broom.get_rooms_to_clean().ToList<Room_To_Clean>().Remove(curr_room);
                }
                return;
            }*/

            smart_broom.get_rooms_to_clean().Enqueue(
                new Room_To_Clean(
                    Room_Status.WAITING,
                    ((CheckedListBox) sender).Items[e.Index].ToString()
                )
            );
        }

        private void show_input_fields()
        {
            this.add_rm_room_input.Visible = true;
            this.add_remove_label.Visible = true;
            this.add_rm_room_input.Visible = true;
            this.room_change.Visible = true;
        }

        private void hide_input_fields()
        {
            this.add_rm_room_input.Visible = false;
            this.add_remove_label.Visible = false;
            this.add_rm_room_input.Visible = false;
            this.room_change.Visible = false;
        }

        private void add_room_click(object sender, EventArgs e)
        {
            show_input_fields();
            add_remove_label.Text = "add new room:";
            add_rm_room_input.Text = "add";
            action = DB_action.ADD;
        }

        private void remove_room_Click(object sender, EventArgs e)
        {
            show_input_fields();
            add_remove_label.Text = "remove room:";
            add_rm_room_input.Text = "remove";
            action = DB_action.REMOVE;
        }

        private void add_room_to_db(String room_name)
        {
            Database.establishe_connection();
            String query = "INSERT INTO SmartBroom (room_name) VALUES (@room_name)";
            SQLiteCommand insert_c = new SQLiteCommand(query, Database.get_connection());
            insert_c.Parameters.AddWithValue("room_name", room_name);

            insert_c.ExecuteNonQuery();
            Database.close_connection();
        }

        private void remove_room_from_db(String room_name)
        {
            Database.establishe_connection();
            String query = "DELETE FROM SmartBroom WHERE room_name=@room_name";
            SQLiteCommand insert_c = new SQLiteCommand(query, Database.get_connection());
            insert_c.Parameters.AddWithValue("room_name", room_name);

            insert_c.ExecuteNonQuery();
            Database.close_connection();
        }

        private void add_rm_room_input_click(object sender, EventArgs e)
        {
            if (room_change.Text.Equals(""))
            {
                MessageBox.Show("The field is empty!");
                return;
            }
            if (action == DB_action.ADD)
                add_room_to_db(room_change.Text);
            else
                remove_room_from_db(room_change.Text);
        }

        private void Smart_Broom_Control_Load(object sender, EventArgs e)
        {
            Database.establishe_connection();
            String query = "SELECT * FROM SmartBroom";
            SQLiteCommand insert_c = new SQLiteCommand(query, Database.get_connection());
            SQLiteDataReader reader = insert_c.ExecuteReader();

            while (reader.Read())
            {
                available_rooms.Items.Add((string)reader.GetValue(0));
            }
            reader.Close();

            Database.close_connection();
        }
    }
}
