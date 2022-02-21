
namespace Smart_Assistant_Design.smart_broom
{
    partial class Smart_Broom_Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.battery_label = new System.Windows.Forms.Label();
            this.presentage = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.task_queue = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.available_rooms = new System.Windows.Forms.CheckedListBox();
            this.rooms_label = new System.Windows.Forms.Label();
            this.start_cleaning = new System.Windows.Forms.Button();
            this.stop_cleaning = new System.Windows.Forms.Button();
            this.battery_life = new System.Windows.Forms.Timer(this.components);
            this.battery_charge = new System.Windows.Forms.Timer(this.components);
            this.room_clean = new System.Windows.Forms.Timer(this.components);
            this.control_refresh = new System.Windows.Forms.Timer(this.components);
            this.add_room = new System.Windows.Forms.Button();
            this.remove_room = new System.Windows.Forms.Button();
            this.room_change = new System.Windows.Forms.TextBox();
            this.add_remove_label = new System.Windows.Forms.Label();
            this.add_rm_room_input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battery_label
            // 
            this.battery_label.AutoSize = true;
            this.battery_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.battery_label.ForeColor = System.Drawing.SystemColors.Window;
            this.battery_label.Location = new System.Drawing.Point(621, 9);
            this.battery_label.Name = "battery_label";
            this.battery_label.Size = new System.Drawing.Size(93, 28);
            this.battery_label.TabIndex = 4;
            this.battery_label.Text = "battery: ";
            // 
            // presentage
            // 
            this.presentage.AutoSize = true;
            this.presentage.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.presentage.ForeColor = System.Drawing.SystemColors.Window;
            this.presentage.Location = new System.Drawing.Point(694, 13);
            this.presentage.Name = "presentage";
            this.presentage.Size = new System.Drawing.Size(58, 25);
            this.presentage.TabIndex = 5;
            this.presentage.Text = "100%";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.SystemColors.Window;
            this.status.Location = new System.Drawing.Point(687, 53);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(56, 25);
            this.status.TabIndex = 7;
            this.status.Text = "sleep";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status_label.ForeColor = System.Drawing.SystemColors.Window;
            this.status_label.Location = new System.Drawing.Point(621, 50);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(80, 28);
            this.status_label.TabIndex = 6;
            this.status_label.Text = "status: ";
            // 
            // task_queue
            // 
            this.task_queue.FormattingEnabled = true;
            this.task_queue.ItemHeight = 15;
            this.task_queue.Location = new System.Drawing.Point(621, 134);
            this.task_queue.Name = "task_queue";
            this.task_queue.Size = new System.Drawing.Size(167, 289);
            this.task_queue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(652, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Task Queue";
            // 
            // available_rooms
            // 
            this.available_rooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.available_rooms.ForeColor = System.Drawing.SystemColors.WindowText;
            this.available_rooms.FormattingEnabled = true;
            this.available_rooms.Location = new System.Drawing.Point(174, 90);
            this.available_rooms.Name = "available_rooms";
            this.available_rooms.Size = new System.Drawing.Size(368, 144);
            this.available_rooms.TabIndex = 10;
            this.available_rooms.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.task_queue_add_room);
            // 
            // rooms_label
            // 
            this.rooms_label.AutoSize = true;
            this.rooms_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rooms_label.ForeColor = System.Drawing.SystemColors.Window;
            this.rooms_label.Location = new System.Drawing.Point(313, 50);
            this.rooms_label.Name = "rooms_label";
            this.rooms_label.Size = new System.Drawing.Size(76, 28);
            this.rooms_label.TabIndex = 11;
            this.rooms_label.Text = "Rooms";
            // 
            // start_cleaning
            // 
            this.start_cleaning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_cleaning.ForeColor = System.Drawing.SystemColors.Window;
            this.start_cleaning.Location = new System.Drawing.Point(175, 277);
            this.start_cleaning.Name = "start_cleaning";
            this.start_cleaning.Size = new System.Drawing.Size(115, 68);
            this.start_cleaning.TabIndex = 12;
            this.start_cleaning.Text = "Start cleaning";
            this.start_cleaning.UseVisualStyleBackColor = true;
            this.start_cleaning.Click += new System.EventHandler(this.start_cleaning_click);
            // 
            // stop_cleaning
            // 
            this.stop_cleaning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop_cleaning.ForeColor = System.Drawing.SystemColors.Window;
            this.stop_cleaning.Location = new System.Drawing.Point(427, 277);
            this.stop_cleaning.Name = "stop_cleaning";
            this.stop_cleaning.Size = new System.Drawing.Size(115, 68);
            this.stop_cleaning.TabIndex = 14;
            this.stop_cleaning.Text = "Stop cleaning";
            this.stop_cleaning.UseVisualStyleBackColor = true;
            this.stop_cleaning.Click += new System.EventHandler(this.stop_cleaning_click);
            // 
            // battery_life
            // 
            this.battery_life.Enabled = true;
            this.battery_life.Interval = 1000;
            this.battery_life.Tick += new System.EventHandler(this.battery_life_tick);
            // 
            // battery_charge
            // 
            this.battery_charge.Enabled = true;
            this.battery_charge.Interval = 2000;
            this.battery_charge.Tick += new System.EventHandler(this.battery_charge_tick);
            // 
            // room_clean
            // 
            this.room_clean.Enabled = true;
            this.room_clean.Interval = 3000;
            // 
            // control_refresh
            // 
            this.control_refresh.Enabled = true;
            this.control_refresh.Interval = 1500;
            this.control_refresh.Tick += new System.EventHandler(this.control_refresh_tick);
            // 
            // add_room
            // 
            this.add_room.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_room.ForeColor = System.Drawing.SystemColors.Window;
            this.add_room.Location = new System.Drawing.Point(34, 90);
            this.add_room.Name = "add_room";
            this.add_room.Size = new System.Drawing.Size(115, 68);
            this.add_room.TabIndex = 15;
            this.add_room.Text = "Add room";
            this.add_room.UseVisualStyleBackColor = true;
            this.add_room.Click += new System.EventHandler(this.add_room_click);
            // 
            // remove_room
            // 
            this.remove_room.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_room.ForeColor = System.Drawing.SystemColors.Window;
            this.remove_room.Location = new System.Drawing.Point(34, 170);
            this.remove_room.Name = "remove_room";
            this.remove_room.Size = new System.Drawing.Size(115, 68);
            this.remove_room.TabIndex = 16;
            this.remove_room.Text = "remove room";
            this.remove_room.UseVisualStyleBackColor = true;
            this.remove_room.Click += new System.EventHandler(this.remove_room_Click);
            // 
            // room_change
            // 
            this.room_change.Location = new System.Drawing.Point(253, 15);
            this.room_change.Name = "room_change";
            this.room_change.Size = new System.Drawing.Size(197, 23);
            this.room_change.TabIndex = 17;
            this.room_change.Visible = false;
            // 
            // add_remove_label
            // 
            this.add_remove_label.AutoSize = true;
            this.add_remove_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_remove_label.ForeColor = System.Drawing.SystemColors.Window;
            this.add_remove_label.Location = new System.Drawing.Point(-2, 10);
            this.add_remove_label.Name = "add_remove_label";
            this.add_remove_label.Size = new System.Drawing.Size(203, 28);
            this.add_remove_label.TabIndex = 18;
            this.add_remove_label.Text = "RoomToAddRemove";
            this.add_remove_label.Visible = false;
            // 
            // add_rm_room_input
            // 
            this.add_rm_room_input.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_rm_room_input.ForeColor = System.Drawing.SystemColors.Window;
            this.add_rm_room_input.Location = new System.Drawing.Point(456, 15);
            this.add_rm_room_input.Name = "add_rm_room_input";
            this.add_rm_room_input.Size = new System.Drawing.Size(78, 23);
            this.add_rm_room_input.TabIndex = 19;
            this.add_rm_room_input.Text = "Add room";
            this.add_rm_room_input.UseVisualStyleBackColor = true;
            this.add_rm_room_input.Visible = false;
            this.add_rm_room_input.Click += new System.EventHandler(this.add_rm_room_input_click);
            // 
            // Smart_Broom_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_rm_room_input);
            this.Controls.Add(this.add_remove_label);
            this.Controls.Add(this.room_change);
            this.Controls.Add(this.remove_room);
            this.Controls.Add(this.add_room);
            this.Controls.Add(this.stop_cleaning);
            this.Controls.Add(this.start_cleaning);
            this.Controls.Add(this.rooms_label);
            this.Controls.Add(this.available_rooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_queue);
            this.Controls.Add(this.status);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.presentage);
            this.Controls.Add(this.battery_label);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Smart_Broom_Control";
            this.Text = "Smart Broom Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label battery_label;
        private System.Windows.Forms.Label presentage;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.ListBox task_queue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox available_rooms;
        private System.Windows.Forms.Label rooms_label;
        private System.Windows.Forms.Button start_cleaning;
        private System.Windows.Forms.Button stop_cleaning;
        private System.Windows.Forms.Timer battery_life;
        private System.Windows.Forms.Timer battery_charge;
        private System.Windows.Forms.Timer room_clean;
        private System.Windows.Forms.Timer control_refresh;
        private System.Windows.Forms.Button add_room;
        private System.Windows.Forms.Button remove_room;
        private System.Windows.Forms.TextBox room_change;
        private System.Windows.Forms.Label add_remove_label;
        private System.Windows.Forms.Button add_rm_room_input;
    }
}