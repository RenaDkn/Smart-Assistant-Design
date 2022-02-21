using Microsoft.Data.Sqlite;
using Smart_Assistant_Design.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.smart_lights
{
    
    public partial class Chooseroom : Form
    {
        public String room;
        
        public Chooseroom()
        {
            InitializeComponent();           
        }

        private void livingroom_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Rooms WHERE RoomName='livingroom'";
            room = "livingroom";
            SqliteCommand command = new SqliteCommand(query, Database.get_connection());
            Database.establishe_connection();
            SqliteDataReader reader = command.ExecuteReader();
            MessageBox.Show(reader.GetValue(0).ToString());
            Database.close_connection();
            var room1 = new Roomclass();
            room1.SetRoom(room);
            room1.SetLights("off");
            room1.SetImage("images/livingroom.jpg");
            Room rm = new Room(room1);
            rm.Show();
            this.Close();
        }

        private void bedroom_Click(object sender, EventArgs e)
        {
            room = "bedroom";
            var room2= new Roomclass();
            room2.SetRoom(room);
            room2.SetLights("off");
            room2.SetImage("images/bedroom.jpg");
            Room rm = new Room(room2);
            rm.Show();
            this.Close();
        }

        private void kitchen_Click(object sender, EventArgs e)
        {
            room = "kitchen";
            var room3 = new Roomclass();
            room3.SetRoom(room);
            room3.SetLights("off");
            room3.SetImage("images/kitchen.jpg");
            Room rm = new Room(room3);
            rm.Show();
            this.Close();
        }

        private void bathroom_Click(object sender, EventArgs e)
        {
            room = "bathroom";
            var room4 = new Roomclass();
            room4.SetRoom(room);
            room4.SetLights("off");
            room4.SetImage("images/bathroom.jpg");
            Room rm = new Room(room4);
            rm.Show();
            this.Close();
        }

        private void Chooseroom_Load(object sender, EventArgs e)
        {
            livingroom.ImageLocation = "images/livingroom.jpg";
            bedroom.ImageLocation = "images/bedroom.jpg";
            kitchen.ImageLocation = "images/kitchen.jpeg";
            bathroom.ImageLocation = "images/bathroom.jpg";
            Room1Label.Text = "Living room";
            Room2Label.Text = "Bed room";
            Room3Label.Text = "Kitchen";
            Room4Label.Text = "Bathroom";
            this.BackColor = Color.FromArgb(217, 187, 160);
            exitbutton.BackColor = Color.FromArgb(3, 88, 140);
            exitbutton.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            Room1Label.BackColor = Color.FromArgb(3, 88, 140);
            Room2Label.BackColor = Color.FromArgb(3, 88, 140);
            Room3Label.BackColor = Color.FromArgb(3, 88, 140);
            Room4Label.BackColor = Color.FromArgb(3, 88, 140);
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            main_window mw = new main_window();
            mw.Show();
            this.Close();
        }
    }
}
