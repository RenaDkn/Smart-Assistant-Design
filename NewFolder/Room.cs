using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.NewFolder
{

    public partial class Room : Form
    {
        public Roomclass r1 = new Roomclass();
        public Room(Roomclass room)
        {

            r1.image = room.image;
            r1.lights = room.lights;
            r1.room = room.room;
            showroom();
            InitializeComponent();


        }
        public void showroom()
        {
            if (r1.lights =="off")
            {
                //ligthsOFF
                this.BackgroundImage = Image.FromFile("images/"+r1.room+"OFF.jpg");
                infotext.Text = "The " + r1.room + "'s lights are OFF!";
                swapligths.Text = "OPEN LIGTHS";
            }
            else
            {
                //lightsON
                this.BackgroundImage = Image.FromFile("images/"+r1.room+"ON.jpg");
                infotext.Text = "The " + r1.room + "'s lights are ON!";
                swapligths.Text = "CLOSE LIGTHS";
            }
        }

        private void swapligths_Click(object sender, EventArgs e)
        {
            if (r1.lights == "off")
            { 
                r1.lights = "on";
                this.BackgroundImage = Image.FromFile("images/" + r1.room + "ON.jpg");
                infotext.Text = "The " + r1.room + "'s lights are ON!";
                swapligths.Text = "CLOSE LIGTHS";
            }
            else
            {
                r1.lights = "off";
                this.BackgroundImage = Image.FromFile("images/" + r1.room + "OFF.jpg");
                infotext.Text = "The " + r1.room + "'s lights are OFF!";
                swapligths.Text = "OPEN LIGTHS";
            }
        }
    }
}
