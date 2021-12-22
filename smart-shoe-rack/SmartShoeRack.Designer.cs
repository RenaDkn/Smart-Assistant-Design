namespace Smart_Assistant_Design.smart_shoe_rack
{
    partial class SmartShoeRack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartShoeRack));
            this.Exit = new System.Windows.Forms.Button();
            this.allshoes_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // allshoes_button
            // 
            this.allshoes_button.Location = new System.Drawing.Point(45, 394);
            this.allshoes_button.Name = "allshoes_button";
            this.allshoes_button.Size = new System.Drawing.Size(126, 29);
            this.allshoes_button.TabIndex = 0;
            this.allshoes_button.Text = "WhatsAllShoes";
            this.allshoes_button.UseVisualStyleBackColor = true;
            this.allshoes_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(251, 394);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(117, 29);
            this.search_button.TabIndex = 0;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(437, 394);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 29);
            this.delete_button.TabIndex = 0;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(627, 394);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(126, 29);
            this.insert_button.TabIndex = 0;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SmartShoeRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.allshoes_button);
            this.Controls.Add(this.Exit);
            this.Name = "SmartShoeRack";
            this.Text = "SmartShoeRack";
            this.Load += new System.EventHandler(this.SmartShoeRack_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button allshoes;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button allshoes_button;
        private System.Windows.Forms.Button insert_button;
    }
}