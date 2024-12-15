namespace PLayGame
{
    partial class MultiplePLayers
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
            this.components = new System.ComponentModel.Container();
            this.LbScore = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LbResult = new System.Windows.Forms.Label();
            this.LabelWord = new System.Windows.Forms.Label();
            this.Txtbword = new System.Windows.Forms.TextBox();
            this.TmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbScore
            // 
            this.LbScore.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.Location = new System.Drawing.Point(151, 107);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(144, 37);
            this.LbScore.TabIndex = 42;
            this.LbScore.Text = "0";
            this.LbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(156, 292);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(139, 30);
            this.ProgressBar1.TabIndex = 41;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Coral;
            this.BtnExit.Font = new System.Drawing.Font("Cascadia Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(427, 348);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(111, 86);
            this.BtnExit.TabIndex = 40;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnNext.Font = new System.Drawing.Font("Cascadia Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(426, 178);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(111, 86);
            this.BtnNext.TabIndex = 39;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.IndianRed;
            this.BtnStart.Font = new System.Drawing.Font("Cascadia Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(426, 9);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(111, 86);
            this.BtnStart.TabIndex = 38;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LbResult
            // 
            this.LbResult.BackColor = System.Drawing.SystemColors.Info;
            this.LbResult.Font = new System.Drawing.Font("Cascadia Code", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResult.Location = new System.Drawing.Point(35, 348);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(374, 86);
            this.LbResult.TabIndex = 37;
            this.LbResult.Text = "Result";
            this.LbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWord
            // 
            this.LabelWord.BackColor = System.Drawing.SystemColors.Info;
            this.LabelWord.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWord.Location = new System.Drawing.Point(35, 9);
            this.LabelWord.Name = "LabelWord";
            this.LabelWord.Size = new System.Drawing.Size(374, 86);
            this.LabelWord.TabIndex = 36;
            this.LabelWord.Text = "Word";
            this.LabelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txtbword
            // 
            this.Txtbword.Font = new System.Drawing.Font("Cascadia Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbword.Location = new System.Drawing.Point(35, 178);
            this.Txtbword.Multiline = true;
            this.Txtbword.Name = "Txtbword";
            this.Txtbword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txtbword.Size = new System.Drawing.Size(374, 86);
            this.Txtbword.TabIndex = 35;
            this.Txtbword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TmCoolDown
            // 
            this.TmCoolDown.Tick += new System.EventHandler(this.TmCoolDown_Tick);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(150, 456);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 37);
            this.lblName.TabIndex = 43;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplePLayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(567, 514);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.LabelWord);
            this.Controls.Add(this.Txtbword);
            this.Name = "MultiplePLayers";
            this.Text = "MultiplePLayers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiplePLayers_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LbResult;
        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.TextBox Txtbword;
        private System.Windows.Forms.Timer TmCoolDown;
        private System.Windows.Forms.Label lblName;
    }
}