namespace Smart_Assistant_Design.NewFolder
{
    partial class Chooseroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chooseroom));
            this.livingroom = new System.Windows.Forms.PictureBox();
            this.bathroom = new System.Windows.Forms.PictureBox();
            this.bedroom = new System.Windows.Forms.PictureBox();
            this.kitchen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.livingroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchen)).BeginInit();
            this.SuspendLayout();
            // 
            // livingroom
            // 
            this.livingroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.livingroom.Image = ((System.Drawing.Image)(resources.GetObject("livingroom.Image")));
            this.livingroom.Location = new System.Drawing.Point(88, 22);
            this.livingroom.Name = "livingroom";
            this.livingroom.Size = new System.Drawing.Size(165, 91);
            this.livingroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livingroom.TabIndex = 0;
            this.livingroom.TabStop = false;
            this.livingroom.Click += new System.EventHandler(this.livingroom_Click);
            // 
            // bathroom
            // 
            this.bathroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bathroom.Image = ((System.Drawing.Image)(resources.GetObject("bathroom.Image")));
            this.bathroom.Location = new System.Drawing.Point(480, 224);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(169, 91);
            this.bathroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bathroom.TabIndex = 1;
            this.bathroom.TabStop = false;
            // 
            // bedroom
            // 
            this.bedroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bedroom.Image = ((System.Drawing.Image)(resources.GetObject("bedroom.Image")));
            this.bedroom.Location = new System.Drawing.Point(480, 22);
            this.bedroom.Name = "bedroom";
            this.bedroom.Size = new System.Drawing.Size(169, 91);
            this.bedroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bedroom.TabIndex = 2;
            this.bedroom.TabStop = false;
            // 
            // kitchen
            // 
            this.kitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitchen.Image = ((System.Drawing.Image)(resources.GetObject("kitchen.Image")));
            this.kitchen.Location = new System.Drawing.Point(88, 224);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(165, 91);
            this.kitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kitchen.TabIndex = 3;
            this.kitchen.TabStop = false;
            // 
            // Chooseroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kitchen);
            this.Controls.Add(this.bedroom);
            this.Controls.Add(this.bathroom);
            this.Controls.Add(this.livingroom);
            this.Name = "Chooseroom";
            this.Text = "Chooseroom";
            ((System.ComponentModel.ISupportInitialize)(this.livingroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox livingroom;
        private System.Windows.Forms.PictureBox bathroom;
        private System.Windows.Forms.PictureBox bedroom;
        private System.Windows.Forms.PictureBox kitchen;
    }
}