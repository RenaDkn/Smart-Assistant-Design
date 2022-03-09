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
using Smart_Assistant_Design.smart_shoe_rack;
using Smart_Assistant_Design.daily_plan;
using Smart_Assistant_Design.samrt_pet_feeder;
using Smart_Assistant_Design.help;
using System.Diagnostics;


namespace Smart_Assistant_Design
{
    public partial class main_window : Form
    {
       
        public main_window()
        {
            InitializeComponent();
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
            smart_broom.BackColor = Color.FromArgb(3, 88, 140);
            smart_broom.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            ShoeRackButton.BackColor = Color.FromArgb(3, 88, 140);
            ShoeRackButton.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            daily_plan.BackColor = Color.FromArgb(3, 88, 140);
            daily_plan.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            smart_pet_feeder.BackColor = Color.FromArgb(3, 88, 140);
            smart_pet_feeder.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            help_btn.BackColor = Color.FromArgb(3, 88, 140);
            help_btn.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
        }

        private void shoeRackButton_click(object sender, EventArgs e)
        {
            new SmartShoeRack().Show();
        }

        private void daily_plan_click(object sender, EventArgs e)
        {
            new Daily_Plan_Manager().Show();
        }

        private void smart_pet_feeder_click(object sender, EventArgs e)
        {
            new Smart_Pet_Feeder().Show();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            new Help_Docs().Show();
        }
    }
}
