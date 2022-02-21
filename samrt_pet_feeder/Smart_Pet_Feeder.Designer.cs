
namespace Smart_Assistant_Design.samrt_pet_feeder
{
    partial class Smart_Pet_Feeder
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
            this.feed = new System.Windows.Forms.Button();
            this.sheduled_feed = new System.Windows.Forms.Button();
            this.watch_mode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.watch_mode_label = new System.Windows.Forms.Label();
            this.sheduled_feeder_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.camera = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bowl_timer = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camera)).BeginInit();
            this.SuspendLayout();
            // 
            // feed
            // 
            this.feed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feed.ForeColor = System.Drawing.SystemColors.Window;
            this.feed.Location = new System.Drawing.Point(98, 315);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(112, 58);
            this.feed.TabIndex = 0;
            this.feed.Text = "Feed";
            this.feed.UseVisualStyleBackColor = true;
            this.feed.Click += new System.EventHandler(this.feed_click);
            // 
            // sheduled_feed
            // 
            this.sheduled_feed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sheduled_feed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sheduled_feed.ForeColor = System.Drawing.SystemColors.Window;
            this.sheduled_feed.Location = new System.Drawing.Point(310, 315);
            this.sheduled_feed.Name = "sheduled_feed";
            this.sheduled_feed.Size = new System.Drawing.Size(112, 58);
            this.sheduled_feed.TabIndex = 1;
            this.sheduled_feed.Text = "Scheduled Feed";
            this.sheduled_feed.UseVisualStyleBackColor = true;
            this.sheduled_feed.Click += new System.EventHandler(this.sheduled_feed_click);
            // 
            // watch_mode
            // 
            this.watch_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch_mode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.watch_mode.ForeColor = System.Drawing.SystemColors.Window;
            this.watch_mode.Location = new System.Drawing.Point(517, 315);
            this.watch_mode.Name = "watch_mode";
            this.watch_mode.Size = new System.Drawing.Size(112, 58);
            this.watch_mode.TabIndex = 2;
            this.watch_mode.Text = "Watch mode";
            this.watch_mode.UseVisualStyleBackColor = true;
            this.watch_mode.Click += new System.EventHandler(this.watch_mode_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(608, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Watch Mode: ";
            // 
            // watch_mode_label
            // 
            this.watch_mode_label.AutoSize = true;
            this.watch_mode_label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.watch_mode_label.ForeColor = System.Drawing.Color.Red;
            this.watch_mode_label.Location = new System.Drawing.Point(728, 24);
            this.watch_mode_label.Name = "watch_mode_label";
            this.watch_mode_label.Size = new System.Drawing.Size(44, 25);
            this.watch_mode_label.TabIndex = 5;
            this.watch_mode_label.Text = "OFF";
            // 
            // sheduled_feeder_label
            // 
            this.sheduled_feeder_label.AutoSize = true;
            this.sheduled_feeder_label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sheduled_feeder_label.ForeColor = System.Drawing.Color.Red;
            this.sheduled_feeder_label.Location = new System.Drawing.Point(728, 58);
            this.sheduled_feeder_label.Name = "sheduled_feeder_label";
            this.sheduled_feeder_label.Size = new System.Drawing.Size(44, 25);
            this.sheduled_feeder_label.TabIndex = 7;
            this.sheduled_feeder_label.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(583, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sheduled Feeder:";
            // 
            // camera
            // 
            this.camera.Image = global::Smart_Assistant_Design.Properties.Resources.bowl_empty;
            this.camera.Location = new System.Drawing.Point(211, 12);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(308, 267);
            this.camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camera.TabIndex = 8;
            this.camera.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(132, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "camera:";
            // 
            // bowl_timer
            // 
            this.bowl_timer.Enabled = true;
            this.bowl_timer.Interval = 5000;
            this.bowl_timer.Tick += new System.EventHandler(this.bowl_timer_tick);
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(12, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 41);
            this.exit.TabIndex = 21;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // Smart_Pet_Feeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.camera);
            this.Controls.Add(this.sheduled_feeder_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.watch_mode_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watch_mode);
            this.Controls.Add(this.sheduled_feed);
            this.Controls.Add(this.feed);
            this.Name = "Smart_Pet_Feeder";
            this.Text = "Smart pet feeder";
            ((System.ComponentModel.ISupportInitialize)(this.camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feed;
        private System.Windows.Forms.Button sheduled_feed;
        private System.Windows.Forms.Button watch_mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label watch_mode_label;
        private System.Windows.Forms.Label sheduled_feeder_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox camera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer bowl_timer;
        private System.Windows.Forms.Button exit;
    }
}