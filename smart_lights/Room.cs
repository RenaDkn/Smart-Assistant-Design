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
            r1.image = room.image;
            r1.lights = room.lights;
            r1.room = room.room;
            infotext.Visible = false;
            infoButtton.Text = "Show Info";
            showroom();

        }
        public void showroom()
        {
            if (r1.lights =="off")
            {
                //ligthsOFF
                this.BackgroundImage = Image.FromFile("images/"+r1.room+"OFF.jpg");
                infotext.Text ="The " + r1.room + "'s lights are OFF!";
                swapligthsbutton.Text = "OPEN LIGTHS";
            }
            else
            {
                //lightsON
                this.BackgroundImage = Image.FromFile("images/"+r1.room+"ON.jpg");
                infotext.Text = "The " + r1.room + "'s lights are ON!";
                swapligthsbutton.Text = "CLOSE LIGTHS";
            }
        }

        private void swapligthsbutton_Click(object sender, EventArgs e)
        {
            if (r1.lights == "off")
            {
                r1.lights = "on";
                this.BackgroundImage = Image.FromFile("images/" + r1.room + "ON.jpg");
                infotext.Text = "The " + r1.room + "'s lights are ON!";
                swapligthsbutton.Text = "CLOSE LIGTHS";
            }
            else
            {
                r1.lights = "off";
                this.BackgroundImage = Image.FromFile("images/" + r1.room + "OFF.jpg");
                infotext.Text = "The " + r1.room + "'s lights are OFF!";
                swapligthsbutton.Text = "OPEN LIGTHS";
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
                infoButtton.Text = "Show Info";
            }
            else
            {
                infotext.Visible = true;
                infoButtton.Text = "Hide Info";
            }
            
        }
    }
    }
