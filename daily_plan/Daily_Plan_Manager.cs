using System;
using System.Drawing;
using System.Windows.Forms;

namespace Smart_Assistant_Design.daily_plan
{
    public partial class Daily_Plan_Manager : Form
    {
        public Daily_Plan_Manager()
        {
            InitializeComponent();
            this.time_pick_field.Format = DateTimePickerFormat.Time;
            this.time_pick_field.ShowUpDown = true;
            // Colors.
            this.BackColor = Color.FromArgb(217, 187, 160);
            this.add_event.BackColor = Color.FromArgb(3, 88, 140);
            this.add_event.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
            this.delete_event.BackColor = Color.FromArgb(3, 88, 140);
            this.delete_event.FlatAppearance.BorderColor = Color.FromArgb(9, 38, 64);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void add_event_click(object sender, System.EventArgs e)
        {
            if (event_name_field.Text.Equals("") ||
                event_type_field.Text.Equals(""))
            {
                MessageBox.Show("Please check that all the reuired fields are filled");
                return;
            }

            // TODO - Add the event to the db.
        }

        private void delete_event_click(object sender, System.EventArgs e)
        {
            if (event_name_field.Text.Equals("") ||
               event_type_field.Text.Equals(""))
            {
                MessageBox.Show("Please check that all the reuired fields are filled");
                return;
            }

            // TOOD - Remove the event from db.
        }

        
    }
}
