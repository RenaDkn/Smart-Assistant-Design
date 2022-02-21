
namespace Smart_Assistant_Design.daily_plan
{
    partial class Daily_Plan_Manager
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.add_event = new System.Windows.Forms.Button();
            this.delete_event = new System.Windows.Forms.Button();
            this.event_name_field = new System.Windows.Forms.TextBox();
            this.date_pick_field = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.event_type_field = new System.Windows.Forms.ComboBox();
            this.time_pick_field = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calendar.Location = new System.Drawing.Point(150, 18);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // add_event
            // 
            this.add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_event.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_event.ForeColor = System.Drawing.SystemColors.Window;
            this.add_event.Location = new System.Drawing.Point(150, 351);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(113, 63);
            this.add_event.TabIndex = 1;
            this.add_event.Text = "Add event";
            this.add_event.UseVisualStyleBackColor = true;
            this.add_event.Click += new System.EventHandler(this.add_event_click);
            // 
            // delete_event
            // 
            this.delete_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_event.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_event.ForeColor = System.Drawing.SystemColors.Window;
            this.delete_event.Location = new System.Drawing.Point(495, 351);
            this.delete_event.Name = "delete_event";
            this.delete_event.Size = new System.Drawing.Size(113, 63);
            this.delete_event.TabIndex = 2;
            this.delete_event.Text = "Delete event";
            this.delete_event.UseVisualStyleBackColor = true;
            this.delete_event.Click += new System.EventHandler(this.delete_event_click);
            // 
            // event_name_field
            // 
            this.event_name_field.Location = new System.Drawing.Point(78, 228);
            this.event_name_field.Name = "event_name_field";
            this.event_name_field.Size = new System.Drawing.Size(203, 23);
            this.event_name_field.TabIndex = 4;
            // 
            // date_pick_field
            // 
            this.date_pick_field.Location = new System.Drawing.Point(443, 228);
            this.date_pick_field.Name = "date_pick_field";
            this.date_pick_field.Size = new System.Drawing.Size(200, 23);
            this.date_pick_field.TabIndex = 5;
            this.date_pick_field.Value = new System.DateTime(2022, 2, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(129, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(129, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(494, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Event Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(493, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event Time";
            // 
            // event_type_field
            // 
            this.event_type_field.FormattingEnabled = true;
            this.event_type_field.Items.AddRange(new object[] {
            "Job interview",
            "Job travel",
            "Job",
            "Go out",
            "Dinner",
            "Date"});
            this.event_type_field.Location = new System.Drawing.Point(78, 295);
            this.event_type_field.Name = "event_type_field";
            this.event_type_field.Size = new System.Drawing.Size(203, 23);
            this.event_type_field.TabIndex = 11;
            // 
            // time_pick_field
            // 
            this.time_pick_field.Location = new System.Drawing.Point(443, 295);
            this.time_pick_field.Name = "time_pick_field";
            this.time_pick_field.Size = new System.Drawing.Size(200, 23);
            this.time_pick_field.TabIndex = 12;
            this.time_pick_field.Value = new System.DateTime(2022, 2, 14, 0, 0, 0, 0);
            // 
            // Daily_Plan_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time_pick_field);
            this.Controls.Add(this.event_type_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_pick_field);
            this.Controls.Add(this.event_name_field);
            this.Controls.Add(this.delete_event);
            this.Controls.Add(this.add_event);
            this.Controls.Add(this.calendar);
            this.Name = "Daily_Plan_Manager";
            this.Text = "Daily Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button add_event;
        private System.Windows.Forms.Button delete_event;
        private System.Windows.Forms.TextBox event_name_field;
        private System.Windows.Forms.DateTimePicker date_pick_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox event_type_field;
        private System.Windows.Forms.DateTimePicker time_pick_field;
    }
}