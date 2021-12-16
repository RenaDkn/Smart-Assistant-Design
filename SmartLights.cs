using Smart_Assistant_Design.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design
{
    public partial class SmartLights : Form
    {
        public Chooseroom cr;
        public SmartLights()
        {
            InitializeComponent();
        }

        private void chooseroombutton_Click(object sender, EventArgs e)
        {
           Chooseroom cr= new Chooseroom();
            cr.Show();
        }

        public static implicit operator SmartLights(Chooseroom v)
        {
            throw new NotImplementedException();
        }
    }
}
