
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rooms_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.battery_life = new System.Windows.Forms.Timer(this.components);
            this.battery_charge = new System.Windows.Forms.Timer(this.components);
            this.room_clean = new System.Windows.Forms.Timer(this.components);
            this.control_refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // battery_label
            // 
            this.battery_label.AutoSize = true;
            this.battery_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.battery_label.Location = new System.Drawing.Point(621, 9);
            this.battery_label.Name = "battery_label";
            this.battery_label.Size = new System.Drawing.Size(84, 28);
            this.battery_label.TabIndex = 4;
            this.battery_label.Text = "battery: ";
            // 
            // presentage
            // 
            this.presentage.AutoSize = true;
            this.presentage.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.presentage.Location = new System.Drawing.Point(694, 13);
            this.presentage.Name = "presentage";
            this.presentage.Size = new System.Drawing.Size(57, 25);
            this.presentage.TabIndex = 5;
            this.presentage.Text = "100%";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.Location = new System.Drawing.Point(687, 53);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(53, 25);
            this.status.TabIndex = 7;
            this.status.Text = "sleep";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status_label.Location = new System.Drawing.Point(621, 50);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(72, 28);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(652, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Task Queue";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Living room",
            "kichen",
            "bathroom",
            "bedroom 1",
            "bedroom 2"});
            this.checkedListBox1.Location = new System.Drawing.Point(174, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(368, 148);
            this.checkedListBox1.TabIndex = 10;
            // 
            // rooms_label
            // 
            this.rooms_label.AutoSize = true;
            this.rooms_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms_label.Location = new System.Drawing.Point(313, 50);
            this.rooms_label.Name = "rooms_label";
            this.rooms_label.Size = new System.Drawing.Size(72, 28);
            this.rooms_label.TabIndex = 11;
            this.rooms_label.Text = "Rooms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start cleaning";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add room";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Stop cleaning";
            this.button3.UseVisualStyleBackColor = true;
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
            // Smart_Broom_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rooms_label);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_queue);
            this.Controls.Add(this.status);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.presentage);
            this.Controls.Add(this.battery_label);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label rooms_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer battery_life;
        private System.Windows.Forms.Timer battery_charge;
        private System.Windows.Forms.Timer room_clean;
        private System.Windows.Forms.Timer control_refresh;
    }
}