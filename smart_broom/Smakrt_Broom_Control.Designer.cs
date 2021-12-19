
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
            this.stop_cleaning = new System.Windows.Forms.Button();
            this.start_cleaning = new System.Windows.Forms.Button();
            this.room_label = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.battery_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stop_cleaning
            // 
            this.stop_cleaning.Location = new System.Drawing.Point(420, 275);
            this.stop_cleaning.Name = "stop_cleaning";
            this.stop_cleaning.Size = new System.Drawing.Size(154, 67);
            this.stop_cleaning.TabIndex = 0;
            this.stop_cleaning.Text = "Stop Cleaning";
            this.stop_cleaning.UseVisualStyleBackColor = true;
            // 
            // start_cleaning
            // 
            this.start_cleaning.Location = new System.Drawing.Point(171, 275);
            this.start_cleaning.Name = "start_cleaning";
            this.start_cleaning.Size = new System.Drawing.Size(154, 67);
            this.start_cleaning.TabIndex = 1;
            this.start_cleaning.Text = "Start Cleaning";
            this.start_cleaning.UseVisualStyleBackColor = true;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.room_label.Location = new System.Drawing.Point(323, 33);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(98, 37);
            this.room_label.TabIndex = 2;
            this.room_label.Text = "Rooms";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "room_1",
            "room_2",
            "room_3",
            "room_4"});
            this.checkedListBox1.Location = new System.Drawing.Point(171, 105);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(403, 130);
            this.checkedListBox1.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(694, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "100%";
            // 
            // Smart_Broom_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.battery_label);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.start_cleaning);
            this.Controls.Add(this.stop_cleaning);
            this.Name = "Smart_Broom_Control";
            this.Text = "Smart Broom Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stop_cleaning;
        private System.Windows.Forms.Button start_cleaning;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label battery_label;
        private System.Windows.Forms.Label label1;
    }
}