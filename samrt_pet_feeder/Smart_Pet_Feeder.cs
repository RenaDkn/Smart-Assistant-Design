using Smart_Assistant_Design.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.samrt_pet_feeder
{
    public partial class Smart_Pet_Feeder : Form
    {
        public Smart_Pet_Feeder()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(217, 187, 160);
            this.feed.BackColor = Color.FromArgb(3, 88, 140);
            this.feed.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.sheduled_feed.BackColor = Color.FromArgb(3, 88, 140);
            this.sheduled_feed.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.watch_mode.BackColor = Color.FromArgb(3, 88, 140);
            this.watch_mode.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
        }

        private void sheduled_feed_click(object sender, EventArgs e)
        {
            if (this.sheduled_feeder_label.Text.Equals("OFF"))
            {
                this.sheduled_feeder_label.Text = "ON";
                this.sheduled_feeder_label.ForeColor = Color.LightGreen;
            }
            else
            {
                this.sheduled_feeder_label.Text = "OFF";
                this.sheduled_feeder_label.ForeColor = Color.Red;
            }
        }

        private void watch_mode_click(object sender, EventArgs e)
        {
            if (this.watch_mode_label.Text.Equals("OFF"))
            {
                this.watch_mode_label.Text = "ON";
                this.watch_mode_label.ForeColor = Color.LightGreen;
            }
            else
            {
                this.watch_mode_label.Text = "OFF";
                this.watch_mode_label.ForeColor = Color.Red;
            }
        }

        private void feed_click(object sender, EventArgs e)
        {
            this.camera.Image = Resources.bowl_full;
        }

        private void bowl_timer_tick(object sender, EventArgs e)
        {
            this.camera.Image = Resources.bowl_empty;
        }
    }
}
