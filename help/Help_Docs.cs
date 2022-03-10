using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.help
{
    public partial class Help_Docs : Form
    {
        public Help_Docs()
        {
            InitializeComponent();
            // Colors
            this.BackColor = Color.FromArgb(217, 187, 160);
            daily_plan_btn.BackColor = Color.FromArgb(3, 88, 140);
            daily_plan_btn.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            smart_broom_btn.BackColor = Color.FromArgb(3, 88, 140);
            smart_broom_btn.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            smart_lights_btn.BackColor = Color.FromArgb(3, 88, 140);
            smart_lights_btn.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            smart_pet_feeder_btn.BackColor = Color.FromArgb(3, 88, 140);
            smart_pet_feeder_btn.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            smart_shoe_rack_btn.BackColor = Color.FromArgb(3, 88, 140);
            smart_shoe_rack_btn.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            exit.BackColor = Color.FromArgb(3, 88, 140);
            exit.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);

        }

        private void open_pdf(String pdf_name)
        {
            Process pdf_proc = new Process();

            pdf_proc.StartInfo = new ProcessStartInfo(pdf_name);
            pdf_proc.StartInfo.UseShellExecute = true;

            pdf_proc.Start();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void smart_pet_feeder_btn_Click(object sender, EventArgs e)
        {
            open_pdf(@"..\..\..\Resources\help pdfs\smart_feeder.pdf");
        }

        private void smart_lights_btn_Click(object sender, EventArgs e)
        {
            open_pdf(@"..\..\..\Resources\help pdfs\smart_lights.pdf");
        }

        private void smart_broom_btn_Click(object sender, EventArgs e)
        {
            open_pdf(@"..\..\..\Resources\help pdfs\smart_broom.pdf");
        }

        private void smart_shoe_rack_btn_Click(object sender, EventArgs e)
        {
            open_pdf(@"..\..\..\Resources\help pdfs\smart_shoe_rack.pdf");
        }

        private void daily_plan_btn_Click(object sender, EventArgs e)
        {
            open_pdf(@"..\..\..\Resources\help pdfs\daily_plan.pdf");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            new main_window().Show();
            this.Close();
        }
    }
}
