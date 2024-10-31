using PLayGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuessTheWordGame
{
    public partial class OnePlayer : Form
    {
        public OnePlayer()
        {
            InitializeComponent();
            this.KeyPreview = true; // Cho phép form lắng nghe sự kiện phím
            this.KeyDown += MultiplePlayers_KeyDown; // Gán sự kiện KeyDown cho form

        }

        private void MultiplePlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn âm thanh "ding" khi nhấn Enter
                btnNext.PerformClick(); // Gọi sự kiện click của nút "Next"
            }
        }

        string[] words = File.ReadAllLines( @"C:\Users\DELL\source\repos\PLayGame\PLayGame\Words.txt");
        int index = 0, score = 0;
        Random random = new Random();
       
        public void checkWord()
        {
            if (txtbword.Text.ToLower().Trim().Equals(words[index]))//Trim() dùng để xóa khoảng trắng thừa trong txtbword
            {
                lbResult.Text = "Correct";
                lbResult.BackColor = Color.Green;
                score++;
            }
            else
            {
                lbResult.Text = "Wrong";
                lbResult.BackColor = Color.Red;
            }

            txtbword.Text = "";
            lbScore.Text = score.ToString() ;
        }


        //create function to get a random word
        private string GetRandomWord()
        {
            index = random.Next(words.Length);
            return words[index];
        }

        //create function to display a words
        public void displayword()
        {
            string word = GetRandomWord();
            int pos1 = random.Next(word.Length);
            int pos2 = random.Next(word.Length);
           
            // Insert blanks at the chosen positions
            word = word.Remove(pos1, 1).Insert(pos1, "_");
            word = word.Remove(pos2, 1).Insert(pos2, "_");
            
            // Display the modified word
            labelWord.Text = word;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int index = random.Next(words.Length);
            score = 0;
            lbResult.Text = "Result";
            lbResult.BackColor = Color.Ivory;
            lbScore.Text = "0";
            displayword();
            btnNext.Enabled = true;

            btnStart.Enabled = false; // Disable start button while in progress

            // Thiết lập giá trị ban đầu của ProgressBar
            progressBar1.Value = 0;
            // Chọn giá trị tối đa phù hợp với thời gian đếm ngược
            progressBar1.Step = Cons.COOL_DOWN_STEP;
            progressBar1.Maximum = Cons.COOL_DOWN_TIME;

            // Bắt đầu Timer
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;
            // Thời gian cập nhật, ví dụ 100ms
            tmCoolDown.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!txtbword.Text.ToLower().Trim().Equals(words[index]))
            {
                tmCoolDown.Enabled = false;
                MessageBox.Show("Trò chơi đã kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                txtbword.Text = "";
                displayword();
                progressBar1.Value = 0;
            }
        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmCoolDown_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep(); // Tăng giá trị lên
            }
            else
            {
                tmCoolDown.Stop(); // Dừng Timer khi thanh ProgressBar đầy
                btnStart.Enabled = true; // Cho phép nhấn lại nút "Start"
                MessageBox.Show("Trò chơi đã kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = false;
                txtbword.Text = " ";
                lbScore.Text = "0";
            }
        }

        
    }
}
