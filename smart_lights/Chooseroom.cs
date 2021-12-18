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
        String room;
        
        public Chooseroom()
        {
            InitializeComponent();
            
           
        }

        private void livingroom_Click(object sender, EventArgs e)
        {
            room = "livingroom";
            Roomclass room1 = new Roomclass();
            room1.room = room;
            room1.lights = "off";
            room1.image= "images/livingroom.jpg";
            Room rm = new Room(room1);
            rm.Show();
        }

        private void bedroom_Click(object sender, EventArgs e)
        {
            room = "bedroom";
            Roomclass room2= new Roomclass();
            room2.room = room;
            room2.lights = "off";
            room2.image = "images/bedroom.jpg";
            Room rm = new Room(room2);
            rm.Show();
            this.Close();
        }

        private void kitchen_Click(object sender, EventArgs e)
        {
            room = "kitchen";
            Roomclass room3 = new Roomclass();
            room3.room = room;
            room3.lights = "off";
            room3.image = "images/kitchen.jpg";
            Room rm = new Room(room3);
            rm.Show();
            this.Close();
        }

        private void bathroom_Click(object sender, EventArgs e)
        {
            room = "bathroom";
            Roomclass room4 = new Roomclass();
            room4.room = room;
            room4.lights = "off";
            room4.image = "images/bathroom.jpg";
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
        }
    }
}
