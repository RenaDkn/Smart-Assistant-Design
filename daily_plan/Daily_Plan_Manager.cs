using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
