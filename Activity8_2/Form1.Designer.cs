namespace Activity8_2
{
    partial class txtLogger
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
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.txtLogInfo = new System.Windows.Forms.TextBox();
            this.btmLogInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(256, 117);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(344, 38);
            this.txtLogPath.TabIndex = 0;
            this.txtLogPath.Text = "c:\\Test\\LogTest.txt";
            // 
            // txtLogInfo
            // 
            this.txtLogInfo.Location = new System.Drawing.Point(256, 284);
            this.txtLogInfo.Name = "txtLogInfo";
            this.txtLogInfo.Size = new System.Drawing.Size(344, 38);
            this.txtLogInfo.TabIndex = 1;
            this.txtLogInfo.Text = "Test Message";
            // 
            // btmLogInfo
            // 
            this.btmLogInfo.Location = new System.Drawing.Point(317, 426);
            this.btmLogInfo.Name = "btmLogInfo";
            this.btmLogInfo.Size = new System.Drawing.Size(207, 58);
            this.btmLogInfo.TabIndex = 2;
            this.btmLogInfo.Text = "Log Info";
            this.btmLogInfo.UseVisualStyleBackColor = true;
            this.btmLogInfo.Click += new System.EventHandler(this.btmLogInfo_Click);
            // 
            // txtLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 612);
            this.Controls.Add(this.btmLogInfo);
            this.Controls.Add(this.txtLogInfo);
            this.Controls.Add(this.txtLogPath);
            this.Name = "txtLogger";
            this.Text = "Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.TextBox txtLogInfo;
        private System.Windows.Forms.Button btmLogInfo;
    }
}

