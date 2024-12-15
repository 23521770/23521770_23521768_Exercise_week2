namespace PLayGame
{
    partial class Room
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
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlRoom
            // 
            this.pnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRoom.Location = new System.Drawing.Point(12, 10);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(805, 623);
            this.pnlRoom.TabIndex = 2;
            this.pnlRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRoom_Paint);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(315, 672);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(178, 36);
            this.btnCreateRoom.TabIndex = 3;
            this.btnCreateRoom.Text = "Tạo Phòng";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click_1);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 720);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.pnlRoom);
            this.Name = "Room";
            this.Text = "Rooms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_FormClosing);
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnCreateRoom;
    }
}