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
    public partial class WatchAllShoes : Form
    {
        string execute,nicknameSearch,attributesSearch;
        int count;
        Shoes obj_shoes;

        public WatchAllShoes(string ex)
        {
            InitializeComponent();
            execute=ex;
        }
        public WatchAllShoes(string ex,string nickname,string attributes)
        {
            InitializeComponent();
            execute = ex;
            nicknameSearch = nickname;
            attributesSearch = attributes;
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

                obj_shoes = new Shoes();
                count = 1;
                obj_shoes = Database.watch_next_shoes(count);
                prev_button.Enabled = true;
                prev_button.Visible = true;
                next_button.Enabled = true;
                next_button.Visible = true;
                try
                {
                    pictureBox1.Image = Image.FromFile("../../../Resources/shoes/" + obj_shoes.GetImage());
                }catch(Exception)
                {
                    pictureBox1.Visible = false;
                }
                nickname_label.Text = "Nickname:" + obj_shoes.GetNickname().ToString();
                index_label.Text = "Index:" + obj_shoes.GetIndex().ToString();
                attributes_label.Text = "Attributes:" + obj_shoes.GetAttributes().ToString();
            }
            else if (execute=="search")
            {
                next_button.Enabled = false;
                next_button.Visible = false;
                prev_button.Enabled = false;
                prev_button.Visible = false;
                info_label.Visible = true;
                count=Database.search_shoes(nicknameSearch, attributesSearch);
                obj_shoes = new Shoes();
                obj_shoes = Database.watch_next_shoes(count);
                if (obj_shoes.GetNickname() == null)
                {
                    pictureBox1.Visible = false;
                    nickname_label.Visible = false;
                    index_label.Visible = false;
                    attributes_label.Visible = false;
                    info_label.Text = "Τα παπούτσια δεν βρέθηκαν!";

                }
                else
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile("../../../Resources/shoes/" + obj_shoes.GetImage());
                    }
                    catch (Exception )
                    {
                        pictureBox1.Visible = false;
                    }
                    nickname_label.Text = "Nickname:" + obj_shoes.GetNickname().ToString();
                    index_label.Text = "Index:" + obj_shoes.GetIndex().ToString();
                    attributes_label.Text = "Attributes:" + obj_shoes.GetAttributes().ToString();
                    info_label.Text = "Τα παπούτσια βρέθηκαν!";
                }
               
            }

        }
        private void next_button_Click(object sender, EventArgs e)
        {
            if (count == 4)
            {
                count = 1;
            }
            else
            {
                count += 1;
            }
            obj_shoes = Database.watch_next_shoes(count);
            pictureBox1.Image = Image.FromFile("../../../Resources/shoes/" + obj_shoes.GetImage());
            nickname_label.Text = "Nickname:" + obj_shoes.GetNickname().ToString();
            index_label.Text = "Index:" + obj_shoes.GetIndex().ToString();
            attributes_label.Text = "Attributes:" + obj_shoes.GetAttributes().ToString();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            SmartShoeRack ssr = new SmartShoeRack();
            ssr.Show();
            this.Close();
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                count = 4;
            }
            else
            {
                count = count - 1;
            }
            obj_shoes = Database.watch_next_shoes(count);
            pictureBox1.Image = Image.FromFile("../../../Resources/shoes/" + obj_shoes.GetImage());
            nickname_label.Text = "Nickname" + obj_shoes.GetNickname().ToString();
            index_label.Text = "Index:" + obj_shoes.GetIndex().ToString();
            attributes_label.Text = "Attributes:" + obj_shoes.GetAttributes().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }   
        
    
}
