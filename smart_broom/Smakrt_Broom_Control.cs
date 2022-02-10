using Smart_Assistant_Design.smart_broom.status;
using Smart_Assistant_Design.smart_broom.rooms;
using System;
using System.Data;
using System.Linq;
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
                    this.stop_cleaning_click(null, null);
                else
                    smart_broom.Presentage -= 2;
            }
               
        }

        private void start_cleaning_click(object sender, EventArgs e)
        {
            // If there is no rooms to clean in the queue.
            if (smart_broom.get_rooms_to_clean().Count == 0)
            {
                MessageBox.Show("Unable to start, no room has been selected.");
                return;
            }
            // Otherwise give the order to start the broom.
            smart_broom.Status = Broom_Status.IN_PROCESS;
        }

        private void stop_cleaning_click(object sender, EventArgs e)
        {
            // Check the state of the broom.
            if (smart_broom.Status == Broom_Status.SLEEP ||
                smart_broom.Status == Broom_Status.CHARGING)
            {
                MessageBox.Show("The broom is already stoped.");
            }

            if (smart_broom.Presentage < 100)
                smart_broom.Status = Broom_Status.CHARGING;
            else
                smart_broom.Status = Broom_Status.SLEEP;
        }

        private void task_queue_add_room(object sender, ItemCheckEventArgs e)
        {
            // Add a new selected room in the queue.
            // TODO - Remove if unchecked.
            smart_broom.get_rooms_to_clean().Enqueue(
                new Room_To_Clean(
                    Room_Status.WAITING,
                    ((CheckedListBox) sender).Items[e.Index].ToString()
                )
            );
        }
    }
}
