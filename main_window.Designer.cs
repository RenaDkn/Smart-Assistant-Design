﻿
namespace Smart_Assistant_Design
{
    partial class main_window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SmartLights = new System.Windows.Forms.Button();
            this.smart_broom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SmartLights
            // 
            this.SmartLights.Location = new System.Drawing.Point(90, 179);
            this.SmartLights.Name = "SmartLights";
            this.SmartLights.Size = new System.Drawing.Size(123, 71);
            this.SmartLights.TabIndex = 0;
            this.SmartLights.Text = "Smart Lights";
            this.SmartLights.UseVisualStyleBackColor = true;
            this.SmartLights.Click += new System.EventHandler(this.SmartLights_Click);
            // 
            // smart_broom
            // 
            this.smart_broom.Location = new System.Drawing.Point(301, 179);
            this.smart_broom.Name = "smart_broom";
            this.smart_broom.Size = new System.Drawing.Size(123, 71);
            this.smart_broom.TabIndex = 1;
            this.smart_broom.Text = "Smart Broom";
            this.smart_broom.UseVisualStyleBackColor = true;
            this.smart_broom.Click += new System.EventHandler(this.smart_broom_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Smart shoe rack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.smart_broom_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.smart_broom);
            this.Controls.Add(this.SmartLights);
            this.Name = "main_window";
            this.Text = "Smart_Broom_Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SmartLights;
        private System.Windows.Forms.Button smart_broom;
        private System.Windows.Forms.Button button1;
    }
}

