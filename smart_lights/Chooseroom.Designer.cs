namespace Smart_Assistant_Design.smart_lights
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
            this.Room1Label = new System.Windows.Forms.Label();
            this.Room2Label = new System.Windows.Forms.Label();
            this.Room3Label = new System.Windows.Forms.Label();
            this.Room4Label = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
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
            this.livingroom.Location = new System.Drawing.Point(88, 62);
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
            this.bathroom.Location = new System.Drawing.Point(489, 224);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(169, 91);
            this.bathroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bathroom.TabIndex = 1;
            this.bathroom.TabStop = false;
            this.bathroom.Click += new System.EventHandler(this.bathroom_Click);
            // 
            // bedroom
            // 
            this.bedroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bedroom.Image = ((System.Drawing.Image)(resources.GetObject("bedroom.Image")));
            this.bedroom.Location = new System.Drawing.Point(489, 62);
            this.bedroom.Name = "bedroom";
            this.bedroom.Size = new System.Drawing.Size(169, 91);
            this.bedroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bedroom.TabIndex = 2;
            this.bedroom.TabStop = false;
            this.bedroom.Click += new System.EventHandler(this.bedroom_Click);
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
            this.kitchen.Click += new System.EventHandler(this.kitchen_Click);
            // 
            // Room1Label
            // 
            this.Room1Label.AutoSize = true;
            this.Room1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room1Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Room1Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Room1Label.Location = new System.Drawing.Point(88, 160);
            this.Room1Label.Name = "Room1Label";
            this.Room1Label.Size = new System.Drawing.Size(62, 19);
            this.Room1Label.TabIndex = 4;
            this.Room1Label.Text = "Room1";
            // 
            // Room2Label
            // 
            this.Room2Label.AutoSize = true;
            this.Room2Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room2Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Room2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Room2Label.Location = new System.Drawing.Point(489, 160);
            this.Room2Label.Name = "Room2Label";
            this.Room2Label.Size = new System.Drawing.Size(62, 19);
            this.Room2Label.TabIndex = 4;
            this.Room2Label.Text = "Room2";
            // 
            // Room3Label
            // 
            this.Room3Label.AutoSize = true;
            this.Room3Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room3Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Room3Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Room3Label.Location = new System.Drawing.Point(88, 340);
            this.Room3Label.Name = "Room3Label";
            this.Room3Label.Size = new System.Drawing.Size(62, 19);
            this.Room3Label.TabIndex = 4;
            this.Room3Label.Text = "Room3";
            // 
            // Room4Label
            // 
            this.Room4Label.AutoSize = true;
            this.Room4Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room4Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Room4Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Room4Label.Location = new System.Drawing.Point(489, 340);
            this.Room4Label.Name = "Room4Label";
            this.Room4Label.Size = new System.Drawing.Size(62, 19);
            this.Room4Label.TabIndex = 4;
            this.Room4Label.Text = "Room4";
            // 
            // exitbutton
            // 
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbutton.Location = new System.Drawing.Point(13, 13);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(94, 29);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Chooseroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Room4Label);
            this.Controls.Add(this.Room3Label);
            this.Controls.Add(this.Room2Label);
            this.Controls.Add(this.Room1Label);
            this.Controls.Add(this.kitchen);
            this.Controls.Add(this.bedroom);
            this.Controls.Add(this.bathroom);
            this.Controls.Add(this.livingroom);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Chooseroom";
            this.Text = "Chooseroom";
            this.Load += new System.EventHandler(this.Chooseroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livingroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox livingroom;
        private System.Windows.Forms.PictureBox bathroom;
        private System.Windows.Forms.PictureBox bedroom;
        private System.Windows.Forms.PictureBox kitchen;
        private System.Windows.Forms.Label Room1Label;
        private System.Windows.Forms.Label Room2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Room4Label;
        private System.Windows.Forms.Label Room3Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbutton;
    }
}