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
        public String room,lights,image;
        
        public Chooseroom()
        {
            InitializeComponent();           
        }
        public static void get_lights(string room)
        {
            Database db = new Database();
            lights=db.return_lights(room);
            
        }
        public static void get_image(string room)
        {
            Database db = new Database();
            image = db.return_image(room);
        }
        private void livingroom_Click(object sender, EventArgs e)
        {
            room = "livingroom";
            var room1 = new Roomclass();
            room1.SetRoom(room);
            get_lights(room);
            room1.SetLights(lights);
            get_image(room);
            room1.SetImage(image);
            Room rm = new Room(room1);
            rm.Show();
            this.Close();
        }

        private void bedroom_Click(object sender, EventArgs e)
        {
            room = "bedroom";
            var room2= new Roomclass();
            room2.SetRoom(room);
            get_lights(room);
            room2.SetLights(lights);
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
            get_lights(room);
            room3.SetLights(lights);
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
            get_lights(room);
            room4.SetLights(lights);
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
