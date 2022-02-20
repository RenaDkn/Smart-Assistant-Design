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
        
        public main_window()
        {
            InitializeComponent();
            new daily_plan.Daily_Plan_Manager().Show();
        }

        private void SmartLights_Click(object sender, EventArgs e)
        {
            Chooseroom cr = new Chooseroom();
            cr.Show();
            this.Hide();
        }

        private void smart_broom_Click(object sender, EventArgs e)
        {
            new Smart_Broom_Control().Show();
        }

        private void main_window_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 187, 160);
            SmartLights.BackColor = Color.FromArgb(3, 88, 140);
            SmartLights.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
        }
    }
}
