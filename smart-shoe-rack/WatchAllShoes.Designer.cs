namespace Smart_Assistant_Design.smart_shoe_rack
{
    partial class WatchAllShoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchAllShoes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.next_button = new System.Windows.Forms.Button();
            this.prev_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.nickname_label = new System.Windows.Forms.Label();
            this.attributes_label = new System.Windows.Forms.Label();
            this.index_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // next_button
            // 
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.next_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.next_button.Location = new System.Drawing.Point(486, 267);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(94, 29);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // prev_button
            // 
            this.prev_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prev_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prev_button.Location = new System.Drawing.Point(171, 267);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(94, 29);
            this.prev_button.TabIndex = 2;
            this.prev_button.Text = "Previous";
            this.prev_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_button.Location = new System.Drawing.Point(13, 13);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(94, 29);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nickname_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nickname_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nickname_label.Location = new System.Drawing.Point(171, 311);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(131, 19);
            this.nickname_label.TabIndex = 4;
            this.nickname_label.Text = "Nickname: heels ";
            // 
            // attributes_label
            // 
            this.attributes_label.AutoSize = true;
            this.attributes_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attributes_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attributes_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attributes_label.Location = new System.Drawing.Point(171, 404);
            this.attributes_label.Name = "attributes_label";
            this.attributes_label.Size = new System.Drawing.Size(138, 19);
            this.attributes_label.TabIndex = 5;
            this.attributes_label.Text = "Attributes: formal";
            // 
            // index_label
            // 
            this.index_label.AutoSize = true;
            this.index_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.index_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.index_label.Location = new System.Drawing.Point(486, 311);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(67, 19);
            this.index_label.TabIndex = 6;
            this.index_label.Text = "Index: 2";
            // 
            // WatchAllShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.index_label);
            this.Controls.Add(this.attributes_label);
            this.Controls.Add(this.nickname_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WatchAllShoes";
            this.Text = "WatchAllShoes";
            this.Load += new System.EventHandler(this.WatchAllShoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.Label attributes_label;
        private System.Windows.Forms.Label index_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Button next_button;
    }
}