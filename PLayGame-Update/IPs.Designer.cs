namespace PLayGame
{
    partial class IPs
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
            this.txtbip = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnHost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbip
            // 
            this.txtbip.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbip.Location = new System.Drawing.Point(219, 6);
            this.txtbip.Name = "txtbip";
            this.txtbip.Size = new System.Drawing.Size(194, 34);
            this.txtbip.TabIndex = 18;
            this.txtbip.Text = "127.0.0.1";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(-1, 79);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(162, 26);
            this.lblRoomName.TabIndex = 17;
            this.lblRoomName.Text = "Tên Người Chơi";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(219, 71);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(194, 34);
            this.txtbName.TabIndex = 16;
            this.txtbName.Text = "Huy";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(63, 9);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(33, 26);
            this.lblIP.TabIndex = 15;
            this.lblIP.Text = "IP";
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(42, 131);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(110, 36);
            this.btnClient.TabIndex = 19;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHost
            // 
            this.btnHost.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.Location = new System.Drawing.Point(241, 131);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(110, 36);
            this.btnHost.TabIndex = 20;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // IPs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 179);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.txtbip);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblIP);
            this.Name = "IPs";
            this.Text = "IPs";
            this.Load += new System.EventHandler(this.IPs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbip;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Button btnHost;
    }
}