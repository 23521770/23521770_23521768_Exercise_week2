namespace PLayGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnMultipleplayer = new System.Windows.Forms.Button();
            this.btn1nc = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guess The Word";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 349);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 146);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuide.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.Location = new System.Drawing.Point(38, 349);
            this.btnGuide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(197, 146);
            this.btnGuide.TabIndex = 7;
            this.btnGuide.Text = "Isntruction";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnMultipleplayer
            // 
            this.btnMultipleplayer.BackColor = System.Drawing.SystemColors.Info;
            this.btnMultipleplayer.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleplayer.Location = new System.Drawing.Point(600, 128);
            this.btnMultipleplayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultipleplayer.Name = "btnMultipleplayer";
            this.btnMultipleplayer.Size = new System.Drawing.Size(201, 146);
            this.btnMultipleplayer.TabIndex = 6;
            this.btnMultipleplayer.Text = "Multiple players";
            this.btnMultipleplayer.UseVisualStyleBackColor = false;
            this.btnMultipleplayer.Click += new System.EventHandler(this.btnMultipleplayer_Click);
            // 
            // btn1nc
            // 
            this.btn1nc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn1nc.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1nc.Location = new System.Drawing.Point(38, 128);
            this.btn1nc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1nc.Name = "btn1nc";
            this.btn1nc.Size = new System.Drawing.Size(197, 146);
            this.btn1nc.TabIndex = 5;
            this.btn1nc.Text = "1 player";
            this.btn1nc.UseVisualStyleBackColor = false;
            this.btn1nc.Click += new System.EventHandler(this.btn1nc_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.SystemColors.Info;
            this.btnChat.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.Location = new System.Drawing.Point(326, 221);
            this.btnChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(201, 146);
            this.btnChat.TabIndex = 10;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(840, 588);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.btnMultipleplayer);
            this.Controls.Add(this.btn1nc);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "GUESS THE WORD GAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnMultipleplayer;
        private System.Windows.Forms.Button btn1nc;
        private System.Windows.Forms.Button btnChat;
    }
}

