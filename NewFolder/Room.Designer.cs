using System;

namespace Smart_Assistant_Design.NewFolder
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
            this.swapligths = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infotext
            // 
            this.infotext.AutoSize = true;
            this.infotext.Location = new System.Drawing.Point(631, 421);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(50, 20);
            this.infotext.TabIndex = 0;
            this.infotext.Text = "label1";
            // 
            // swapligths
            // 
            this.swapligths.Location = new System.Drawing.Point(558, 12);
            this.swapligths.Name = "swapligths";
            this.swapligths.Size = new System.Drawing.Size(94, 29);
            this.swapligths.TabIndex = 1;
            this.swapligths.Text = "Lights";
            this.swapligths.UseVisualStyleBackColor = true;
            this.swapligths.Click += new System.EventHandler(this.swaplights_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swapligths);
            this.Controls.Add(this.infotext);
            this.Name = "Room";
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void swaplights_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label infotext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button swapligths;
    }
}