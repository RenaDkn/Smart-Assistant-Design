using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.NewFolder
{
    
    public partial class Chooseroom : Form
    {
        String room;
        
        public Chooseroom()
        {
            InitializeComponent();
            livingroom.ImageLocation = "images/livingroom.jpg";
            bedroom.ImageLocation= "images/bedroom.jpg";
            kitchen.ImageLocation= "images/kitchen.jpeg";
            bathroom.ImageLocation= "images/bathroom.jpg";
           
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
    }
}
