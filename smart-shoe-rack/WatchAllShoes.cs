using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.smart_shoe_rack
{
    public partial class WatchAllShoes : Form
    {
        string execute;
        public WatchAllShoes(string ex)
        {
            InitializeComponent();
            execute=ex;
        }

      

        private void WatchAllShoes_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 187, 160);
            exit_button.BackColor = Color.FromArgb(3, 88, 140);
            exit_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            prev_button.BackColor = Color.FromArgb(3, 88, 140);
            prev_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            next_button.BackColor = Color.FromArgb(3, 88, 140);
            next_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            nickname_label.BackColor = Color.FromArgb(3, 88, 140);
            attributes_label.BackColor = Color.FromArgb(3, 88, 140);
            index_label.BackColor = Color.FromArgb(3, 88, 140);
            if (execute == "find")
            {
                prev_button.Enabled = false;
                prev_button.Visible = false;
                next_button.Enabled = false;
                next_button.Visible = false;
               //pictureBox1.ImageLocation = "shoes/shoes2.png";
                
            }
            else
            {

            }

        }
    }
}
