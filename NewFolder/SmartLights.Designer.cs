﻿namespace Smart_Assistant_Design.NewFolder
{
    partial class SmartLights
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
            this.chooseroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseroom
            // 
            this.chooseroom.Location = new System.Drawing.Point(367, 211);
            this.chooseroom.Name = "chooseroom";
            this.chooseroom.Size = new System.Drawing.Size(109, 32);
            this.chooseroom.TabIndex = 0;
            this.chooseroom.Text = "ChooseRoom";
            this.chooseroom.UseVisualStyleBackColor = true;
            this.chooseroom.Click += new System.EventHandler(this.chooseroom_Click);
            // 
            // SmartLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseroom);
            this.Name = "SmartLights";
            this.Text = "SmartLights";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseroom;
    }
}