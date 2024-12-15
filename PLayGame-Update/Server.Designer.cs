namespace PLayGame
{
    partial class Server
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(360, 288);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 39);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(8, 34);
            this.lsvMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(432, 227);
            this.lsvMessage.TabIndex = 4;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // txbMessage
            // 
            this.txbMessage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbMessage.Location = new System.Drawing.Point(7, 288);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(347, 40);
            this.txbMessage.TabIndex = 3;
            // 
            // Server
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 360);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.txbMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txbMessage;
    }
}