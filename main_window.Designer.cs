
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
            this.ShoeRackButton = new System.Windows.Forms.Button();
            this.daily_plan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SmartLights
            // 
            this.SmartLights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SmartLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SmartLights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmartLights.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SmartLights.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SmartLights.Location = new System.Drawing.Point(36, 134);
            this.SmartLights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SmartLights.Name = "SmartLights";
            this.SmartLights.Size = new System.Drawing.Size(108, 53);
            this.SmartLights.TabIndex = 0;
            this.SmartLights.Text = "Smart Lights";
            this.SmartLights.UseVisualStyleBackColor = true;
            this.SmartLights.Click += new System.EventHandler(this.SmartLights_Click);
            // 
            // smart_broom
            // 
            this.smart_broom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smart_broom.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smart_broom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.smart_broom.Location = new System.Drawing.Point(165, 134);
            this.smart_broom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.smart_broom.Name = "smart_broom";
            this.smart_broom.Size = new System.Drawing.Size(108, 53);
            this.smart_broom.TabIndex = 1;
            this.smart_broom.Text = "Smart Broom";
            this.smart_broom.UseVisualStyleBackColor = true;
            this.smart_broom.Click += new System.EventHandler(this.smart_broom_Click);
            // 
            // ShoeRackButton
            // 
            this.ShoeRackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShoeRackButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShoeRackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShoeRackButton.Location = new System.Drawing.Point(488, 134);
            this.ShoeRackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShoeRackButton.Name = "ShoeRackButton";
            this.ShoeRackButton.Size = new System.Drawing.Size(108, 53);
            this.ShoeRackButton.TabIndex = 2;
            this.ShoeRackButton.Text = "SmartShoeRack";
            this.ShoeRackButton.UseVisualStyleBackColor = true;
            this.ShoeRackButton.Click += new System.EventHandler(this.ShoeRackButton_Click);
            // 
            // daily_plan
            // 
            this.daily_plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daily_plan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daily_plan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.daily_plan.Location = new System.Drawing.Point(318, 134);
            this.daily_plan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daily_plan.Name = "daily_plan";
            this.daily_plan.Size = new System.Drawing.Size(108, 53);
            this.daily_plan.TabIndex = 3;
            this.daily_plan.Text = "Daily Plan";
            this.daily_plan.UseVisualStyleBackColor = true;
            this.daily_plan.Click += new System.EventHandler(this.daily_plan_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.daily_plan);
            this.Controls.Add(this.ShoeRackButton);
            this.Controls.Add(this.smart_broom);
            this.Controls.Add(this.SmartLights);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main_window";
            this.Text = "Smart_Broom_Control";
            this.Load += new System.EventHandler(this.main_window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SmartLights;
        private System.Windows.Forms.Button smart_broom;
        private System.Windows.Forms.Button ShoeRackButton;
        private System.Windows.Forms.Button daily_plan;
    }
}

