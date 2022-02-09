using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.smart_broom
{
    public partial class Smart_Broom_Control : Form
    {
        private Smart_Broom smart_broom;

        public Smart_Broom_Control()
        {
            InitializeComponent();
            smart_broom = new Smart_Broom();
        }

        private void refresh_control_panel()
        {
            // Refresh presentage label.
            this.presentage.Text = smart_broom.Presentage.ToString() + " %";
            // Refresh status label.
            this.status.Text = (smart_broom.Status == Broom_Status.SLEEP) ? "sleep" : 
                                (smart_broom.Status == Broom_Status.IN_PROCESS)? "in progress": "charging";
            // Refresh task queue.
            this.task_queue.Items.Clear();
            smart_broom.get_rooms_to_clean().Select(curr_room =>
                this.task_queue.Items.Add(curr_room)
            );
        }

        private void control_refresh_tick(object sender, EventArgs e)
        {
            // Refresh control panel every 1.5 seconds.
            this.refresh_control_panel();
        }

        private void battery_charge_tick(object sender, EventArgs e)
        {
            // Charge the battery of the broom. The battery will start charging if the broom is on base.
            if (smart_broom.Status == Broom_Status.CHARGING)
            {
                if (smart_broom.Presentage == 100)
                    smart_broom.Status = Broom_Status.SLEEP;
                else
                    smart_broom.Presentage += 2;
            }
        }

        private void battery_life_tick(object sender, EventArgs e)
        {
            // Decrease the battery of the broom while is working.
            if (smart_broom.Status == Broom_Status.IN_PROCESS)
            {
                if (smart_broom.Presentage < 15)
                    return;
                    // TODO - Stop claning.
                else
                    smart_broom.Presentage -= 2;
            }
               
        }
    }
}
