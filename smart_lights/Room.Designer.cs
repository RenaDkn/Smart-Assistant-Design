using System;

namespace Smart_Assistant_Design.smart_lights
{
    partial class Room
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
            this.infotext = new System.Windows.Forms.Label();
            this.swapligthsbutton = new System.Windows.Forms.Button();
            this.changeroom = new System.Windows.Forms.Button();
            this.infoButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infotext
            // 
            this.infotext.AutoSize = true;
            this.infotext.Location = new System.Drawing.Point(486, 388);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(48, 20);
            this.infotext.TabIndex = 0;
            this.infotext.Text = "Lights";
            // 
            // swapligthsbutton
            // 
            this.swapligthsbutton.Location = new System.Drawing.Point(558, 12);
            this.swapligthsbutton.Name = "swapligthsbutton";
            this.swapligthsbutton.Size = new System.Drawing.Size(131, 29);
            this.swapligthsbutton.TabIndex = 1;
            this.swapligthsbutton.Text = "button1";
            this.swapligthsbutton.UseVisualStyleBackColor = true;
            this.swapligthsbutton.Click += new System.EventHandler(this.swapligthsbutton_Click);
            // 
            // changeroom
            // 
            this.changeroom.Location = new System.Drawing.Point(12, 12);
            this.changeroom.Name = "changeroom";
            this.changeroom.Size = new System.Drawing.Size(94, 29);
            this.changeroom.TabIndex = 2;
            this.changeroom.Text = "Exit";
            this.changeroom.UseVisualStyleBackColor = true;
            this.changeroom.Click += new System.EventHandler(this.changeroom_Click);
            // 
            // infoButtton
            // 
            this.infoButtton.Location = new System.Drawing.Point(477, 333);
            this.infoButtton.Name = "infoButtton";
            this.infoButtton.Size = new System.Drawing.Size(94, 29);
            this.infoButtton.TabIndex = 3;
            this.infoButtton.Text = "button1";
            this.infoButtton.UseVisualStyleBackColor = true;
            this.infoButtton.Click += new System.EventHandler(this.infoButtton_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoButtton);
            this.Controls.Add(this.changeroom);
            this.Controls.Add(this.swapligthsbutton);
            this.Controls.Add(this.infotext);
            this.Name = "Room";
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion
        public System.Windows.Forms.Label infotext;
        private System.Windows.Forms.Button swapligthsbutton;
        private System.Windows.Forms.Button changeroom;
        private System.Windows.Forms.Button infoButtton;
    }
}