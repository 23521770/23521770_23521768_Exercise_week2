namespace GuessTheWordGame
{
    partial class OnePlayer
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
            this.lbScore = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.txtbword = new System.Windows.Forms.TextBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(135, 105);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(144, 37);
            this.lbScore.TabIndex = 34;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(140, 289);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 30);
            this.progressBar1.TabIndex = 33;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.Font = new System.Drawing.Font("Cascadia Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(412, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 86);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNext.Font = new System.Drawing.Font("Cascadia Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(411, 176);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 86);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.IndianRed;
            this.btnStart.Font = new System.Drawing.Font("Cascadia Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(411, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 86);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbResult.BackColor = System.Drawing.SystemColors.Info;
            this.lbResult.Font = new System.Drawing.Font("Cascadia Code", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(19, 333);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(374, 99);
            this.lbResult.TabIndex = 29;
            this.lbResult.Text = "Result";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // labelWord
            // 
            this.labelWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWord.BackColor = System.Drawing.SystemColors.Info;
            this.labelWord.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(19, 7);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(374, 98);
            this.labelWord.TabIndex = 28;
            this.labelWord.Text = "Word";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbword
            // 
            this.txtbword.Font = new System.Drawing.Font("Cascadia Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbword.Location = new System.Drawing.Point(19, 176);
            this.txtbword.Multiline = true;
            this.txtbword.Name = "txtbword";
            this.txtbword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbword.Size = new System.Drawing.Size(374, 86);
            this.txtbword.TabIndex = 27;
            this.txtbword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick_1);
            // 
            // OnePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(544, 467);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.txtbword);
            this.Name = "OnePlayer";
            this.Text = "OnePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox txtbword;
        private System.Windows.Forms.Timer tmCoolDown;
    }
}