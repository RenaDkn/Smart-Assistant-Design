using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.smart_shoe_rack
{
    public partial class EditShoeRack : Form
    {
        string execute;
        public EditShoeRack(string ex)
        {
            InitializeComponent();
            execute = ex;
        }

        private void EditShoeRack_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 187, 160);
            image_button.BackColor = Color.FromArgb(3, 88, 140);
            image_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            execute_button.BackColor = Color.FromArgb(3, 88, 140);
            execute_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            nickname_label.BackColor = Color.FromArgb(3, 88, 140);
            attributes_label.BackColor = Color.FromArgb(3, 88, 140);
            index_label.BackColor = Color.FromArgb(3, 88, 140);
            image_label.BackColor = Color.FromArgb(3, 88, 140);
            if (execute == "watch")
            {
                image_button.Visible = false;
                

            }else if (execute == "search")
            {
                image_button.Visible = false;
                image_button.Enabled = false;
                image_label.Visible = false;
                execute_button.Text = "Search";
                index_label.Visible = false;
                index_textBox.Enabled = false;
                index_textBox.Visible = false;
                


            }
            else if (execute == "delete")
            {

            }
            else
            {

            }
        }

        private void image_button_Click(object sender, EventArgs e)
        {

        }

        private void execute_button_Click(object sender, EventArgs e)
        {

        }
    }
}
