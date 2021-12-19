using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_Assistant_Design.smart_lights;
using Smart_Assistant_Design.smart_broom;

namespace Smart_Assistant_Design
{
    public partial class main_window : Form
    {
        SmartLights sm = new SmartLights();
        public main_window()
        {
            InitializeComponent();
        }

        private void SmartLights_Click(object sender, EventArgs e)
        {
            sm.Show();

        }

        private void smart_broom_Click(object sender, EventArgs e)
        {
            new Smart_Broom_Control().Show();
        }
    }
}
