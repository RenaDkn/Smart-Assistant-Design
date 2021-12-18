using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.NewFolder
{
    public partial class SmartLights : Form
    {
        Chooseroom cs = new Chooseroom();
        public SmartLights()
        {
            InitializeComponent();
        }

        private void chooseroom_Click(object sender, EventArgs e)
        {
            cs.Show();
        }
    }
}
