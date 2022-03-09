using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.smart_lights
{

    public partial class Room : Form
    {
        public Roomclass r1 = new Roomclass();
        public Room(Roomclass room)
        {
            
            InitializeComponent();
            r1.SetRoom(room.GetRoom());
            r1.SetLights(room.GetLights());
            r1.SetImage(room.GetImage());
            infotext.Visible = false;
            infoButtton.Text = "Show info";
            showroom();
           

        }
        private void showroom()
        {
            if (r1.GetLights()=="off")
            {
                //ligthsOFF
                this.BackgroundImage = Image.FromFile("images/"+r1.GetRoom()+"OFF.jpg");
                infotext.Text ="The " + r1.GetRoom() + "'s lights are OFF!";
                swapligthsbutton.Text = "Open";
            }
            else
            {
                //lightsON
                this.BackgroundImage = Image.FromFile("images/"+r1.GetRoom()+"ON.jpg");
                infotext.Text = "The " + r1.GetRoom() + "'s lights are ON!";
                swapligthsbutton.Text = "Close";
            }
        }

        private void swapligthsbutton_Click(object sender, EventArgs e)
        {
            if (r1.GetLights() == "off")
            {
                r1.SetLights("on");
                this.BackgroundImage = Image.FromFile("images/" + r1.GetRoom()+ "ON.jpg");
                infotext.Text = "The " + r1.GetRoom() + "'s lights are ON!";
                swapligthsbutton.Text = "Close";
             
            }
            else
            {
                r1.SetLights("off");
                this.BackgroundImage = Image.FromFile("images/" + r1.GetRoom()+ "OFF.jpg");
                infotext.Text = "The " + r1.GetRoom()+ "'s lights are OFF!";
                swapligthsbutton.Text = "Open";
            }
        }

        private void changeroom_Click(object sender, EventArgs e)
        {
            Chooseroom cr = new Chooseroom();
            cr.Show();
            this.Close();
        }

        private void infoButtton_Click(object sender, EventArgs e)
        {
            if (infotext.Visible)
            {
                infotext.Visible = false;
                infoButtton.Text = "Show info";
            }
            else
            {
                infotext.Visible = true;
                infoButtton.Text = "Hide info";
            }
            
        }

        private void Room_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 187, 160);
            swapligthsbutton.BackColor = Color.FromArgb(3, 88, 140);
            swapligthsbutton.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            infoButtton.BackColor = Color.FromArgb(3, 88, 140);
            infoButtton.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            changeroom.BackColor = Color.FromArgb(3, 88, 140);
            changeroom.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            infotext.BackColor= Color.FromArgb(3, 88, 140);
        }
    }
}
