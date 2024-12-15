namespace PLayGame
{
    partial class IP
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtbRoomName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(84, 79);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 46);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(12, 15);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(114, 26);
            this.lblRoomName.TabIndex = 11;
            this.lblRoomName.Text = "Tên Phòng";
            // 
            // txtbRoomName
            // 
            this.txtbRoomName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRoomName.Location = new System.Drawing.Point(135, 12);
            this.txtbRoomName.Name = "txtbRoomName";
            this.txtbRoomName.Size = new System.Drawing.Size(194, 34);
            this.txtbRoomName.TabIndex = 10;
            // 
            // IP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 139);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtbRoomName);
            this.Controls.Add(this.btnConnect);
            this.Name = "IP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IP_FormClosing);
            this.Load += new System.EventHandler(this.IP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblRoomName;
        public System.Windows.Forms.TextBox txtbRoomName;
    }
}