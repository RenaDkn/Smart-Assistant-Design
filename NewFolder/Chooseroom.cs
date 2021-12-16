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
    
        
        public Chooseroom()
        {
            livingroom.ImageLocation = "images/livingroom.jpg";
            bedroom.ImageLocation= "images/bedroom.jpg";
            kitchen.ImageLocation= "images/kitchen.jpeg";
            bathroom.ImageLocation= "images/bathroom.jpg";
            InitializeComponent();
        }

        private void livingroom_Click(object sender, EventArgs e)
        {
           
        }
    }
}
