namespace Smart_Assistant_Design
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
            this.chooseroombutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseroombutton
            // 
            this.chooseroombutton.Location = new System.Drawing.Point(313, 194);
            this.chooseroombutton.Name = "chooseroombutton";
            this.chooseroombutton.Size = new System.Drawing.Size(167, 47);
            this.chooseroombutton.TabIndex = 0;
            this.chooseroombutton.Text = "Choose room";
            this.chooseroombutton.UseVisualStyleBackColor = true;
            this.chooseroombutton.Click += new System.EventHandler(this.chooseroombutton_Click);
            // 
            // SmartLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseroombutton);
            this.Name = "SmartLights";
            this.Text = "SmartLights";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseroombutton;
    }
}