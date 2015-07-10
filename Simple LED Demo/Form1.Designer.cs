namespace Simple_LED_Demo
{
    partial class Form1
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
            this.btnFindDev = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLEDOn = new System.Windows.Forms.Button();
            this.btnLEDOff = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindDev
            // 
            this.btnFindDev.Location = new System.Drawing.Point(12, 27);
            this.btnFindDev.Name = "btnFindDev";
            this.btnFindDev.Size = new System.Drawing.Size(198, 32);
            this.btnFindDev.TabIndex = 0;
            this.btnFindDev.Text = "Find Device";
            this.btnFindDev.UseVisualStyleBackColor = true;
            this.btnFindDev.Click += new System.EventHandler(this.btnFindDev_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Enabled = false;
            this.btnConfig.Location = new System.Drawing.Point(12, 65);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(198, 32);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Configure RA0 as output";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnLEDOn
            // 
            this.btnLEDOn.Enabled = false;
            this.btnLEDOn.Location = new System.Drawing.Point(12, 103);
            this.btnLEDOn.Name = "btnLEDOn";
            this.btnLEDOn.Size = new System.Drawing.Size(198, 32);
            this.btnLEDOn.TabIndex = 0;
            this.btnLEDOn.Text = "LED On";
            this.btnLEDOn.UseVisualStyleBackColor = true;
            this.btnLEDOn.Click += new System.EventHandler(this.btnLEDOn_Click);
            // 
            // btnLEDOff
            // 
            this.btnLEDOff.Enabled = false;
            this.btnLEDOff.Location = new System.Drawing.Point(12, 141);
            this.btnLEDOff.Name = "btnLEDOff";
            this.btnLEDOff.Size = new System.Drawing.Size(198, 32);
            this.btnLEDOff.TabIndex = 0;
            this.btnLEDOff.Text = "LED Off";
            this.btnLEDOff.UseVisualStyleBackColor = true;
            this.btnLEDOff.Click += new System.EventHandler(this.btnLEDOff_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(58, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(109, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Disconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 184);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLEDOff);
            this.Controls.Add(this.btnLEDOn);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnFindDev);
            this.Name = "Form1";
            this.Text = "Simple LED Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDev;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLEDOn;
        private System.Windows.Forms.Button btnLEDOff;
        private System.Windows.Forms.Label lblStatus;
    }
}

