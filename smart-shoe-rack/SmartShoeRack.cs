using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.smart_shoe_rack
{
    public partial class SmartShoeRack : Form
    {
        string ex;
        public SmartShoeRack()
        {
            InitializeComponent();           
        }

        private void SmartShoeRack_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 187, 160);
            Exitbutton.BackColor = Color.FromArgb(3, 88, 140);
            Exitbutton.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            allshoes_button.BackColor = Color.FromArgb(3, 88, 140);
            allshoes_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            search_button.BackColor = Color.FromArgb(3, 88, 140);
            search_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            delete_button.BackColor = Color.FromArgb(3, 88, 140);
            delete_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            insert_button.BackColor = Color.FromArgb(3, 88, 140);
            insert_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            find_button.BackColor = Color.FromArgb(3, 88, 140);
            find_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            

        }

        private void find_button_Click(object sender, EventArgs e)
        {
            ex = "find";
            new WatchAllShoes(ex).Show();
            this.Close();
        }

        private void allshoes_button_Click(object sender, EventArgs e)
        {
            ex = "watch";
            new WatchAllShoes(ex).Show();
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            ex = "search";
            new EditShoeRack(ex).Show();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            ex = "delete";
            new EditShoeRack(ex).Show();
            this.Close();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            ex = "insert";
            new EditShoeRack(ex).Show();
            this.Close();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            new main_window().Show();
            this.Close();
        }
    }
}
