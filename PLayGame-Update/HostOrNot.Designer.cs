namespace PLayGame
{
    partial class HostOrNot
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
            this.btnHost = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHost
            // 
            this.btnHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.Location = new System.Drawing.Point(12, 65);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(275, 52);
            this.btnHost.TabIndex = 14;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(275, 47);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // HostOrNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 135);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.btnConnect);
            this.Name = "HostOrNot";
            this.Text = "HostOrNot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnConnect;
    }
}