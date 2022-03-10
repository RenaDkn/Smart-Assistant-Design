using Smart_Assistant_Design.db;
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
        string execute,nickname,attributes,image,index;

        private void exit_button_Click(object sender, EventArgs e)
        {
            SmartShoeRack ssr = new SmartShoeRack();
            ssr.Show();
            this.Close();
        }

        public EditShoeRack(string ex)
        {
            InitializeComponent();
            execute = ex;
        }

        private void EditShoeRack_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 187, 160);
            exit_button.BackColor = Color.FromArgb(3, 88, 140);
            exit_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            image_button.BackColor = Color.FromArgb(3, 88, 140);
            image_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            execute_button.BackColor = Color.FromArgb(3, 88, 140);
            execute_button.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            nickname_label.BackColor = Color.FromArgb(3, 88, 140);
            attributes_label.BackColor = Color.FromArgb(3, 88, 140);
            index_label.BackColor = Color.FromArgb(3, 88, 140);
            image_label.BackColor = Color.FromArgb(3, 88, 140);
            if (execute == "search")
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
                image_button.Visible = false;
                image_button.Enabled = false;
                image_label.Visible = false;
                execute_button.Text = "Delete";
                index_label.Visible = false;
                index_textBox.Enabled = false;
                index_textBox.Visible = false;
            }
            else if (execute=="insert")
            {
                execute_button.Text = "Insert";

            }
        }

        private void image_button_Click(object sender, EventArgs e)
        {

        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            if (execute == "search")
            {
                 nickname = nickname_textBox.Text;
                 attributes = attributes_textBox.Text;
                new WatchAllShoes(execute,nickname,attributes).Show();
            }else if (execute == "delete")
            {
                nickname = nickname_textBox.Text;
                attributes = attributes_textBox.Text;
                Database.delete_shoes(nickname, attributes);
               
            }else if (execute == "insert")
            {
                nickname = nickname_textBox.Text;
                attributes = attributes_textBox.Text;
                index = index_textBox.Text;
                Database.insert_shoes(nickname, index, attributes);
                MessageBox.Show("Η εισαγωγή έγινε επιτυχώς");
            }
        }
    }
}
