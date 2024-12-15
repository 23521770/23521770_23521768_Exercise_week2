namespace PLayGame
{
    partial class Client
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
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMessage
            // 
            this.txbMessage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbMessage.Location = new System.Drawing.Point(12, 353);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(390, 49);
            this.txbMessage.TabIndex = 0;
            // 
            // lsvMessage
            // 
            this.lsvMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(13, 35);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(485, 283);
            this.lsvMessage.TabIndex = 1;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSend.Font = new System.Drawing.Font("VNF-Comic Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(409, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 49);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.txbMessage);
            this.Name = "Client";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.Button btnSend;
    }
}