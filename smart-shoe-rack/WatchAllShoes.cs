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
        int image;
        
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
            info_label.BackColor = Color.FromArgb(3, 88, 140);
            info_label.Visible = false;
            if (execute == "find")
            {
                prev_button.Enabled = false;
                prev_button.Visible = false;
                next_button.Enabled = false;
                next_button.Visible = false;
                info_label.Visible = true;

            }
            else if (execute == "watch")
            {
                prev_button.Enabled = true;
                prev_button.Visible = true;
                next_button.Enabled = true;
                next_button.Visible = true;

                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes1.jpg");
                image = 1;
            }
            else
            {

            }

        }
        private void next_button_Click(object sender, EventArgs e)
        {
      
            if (image == 1)
            {
                image = 2;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes2.png");
            }
            else if (image==2)
            {
                image = 3;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes"+image+".jpg");
            }else if (image == 3)
            {
                image = 4;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes" + image + ".jpg");
            }
            else
            {
                image = 1;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes" + image + ".jpg");
            }
            
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            if (image == 1)
            {
                image = 4;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes" + image + ".jpg");
            }
            else if (image == 2)
            {
                image = 1;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes" + image + ".jpg");
            }
            else if (image == 3)
            {
                image = 2;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes2.png");
            }
            else
            {
                image = 3;
                pictureBox1.Image = Image.FromFile("../../../Resources/shoes/shoes" + image + ".jpg");
            }

        }
    }   
        
    
}
