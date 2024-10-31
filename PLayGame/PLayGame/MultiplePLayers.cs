﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLayGame
{
    public partial class MultiplePLayers : Form
    {
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
        private char PlayerChar;
        private char OpponentChar;
        private bool isMyTurn;

        private int opponentScore = 0; // Track the opponent's score

        string[] words = File.ReadAllLines(@"C:\Users\DELL\source\repos\PLayGame\PLayGame\Words.txt");
        int index = 0, score = 0;
        Random random = new Random();

        public MultiplePLayers(bool isHost, string ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;

            CheckForIllegalCrossThreadCalls = false;

            isMyTurn = isHost;

            if (isHost)
            {
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }

            if (isMyTurn)
                UnfreezeBoard();
            else
                FreezeBoard();

            this.KeyPreview = true; // Cho phép form lắng nghe sự kiện phím
            this.KeyDown += MultiplePlayers_KeyDown; // Gán sự kiện KeyDown cho form

        }

        /*MessageReceiver: Đây là một đối tượng thuộc lớp BackgroundWorker được sử dụng để thực hiện một tác vụ nền. 
        ác vụ này thường là những công việc chạy song song với giao diện người dùng (UI) mà không làm gián đoạn hoạt động của UI.
        CancellationPending: Đây là một thuộc tính của đối tượng BackgroundWorker. 
        Nó sẽ có giá trị true khi có yêu cầu hủy bỏ tác vụ nền và có giá trị false nếu không có yêu cầu hủy bỏ.
         */

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!MessageReceiver.CancellationPending)
            {
                ReceiveMove(); // Nhận tín hiệu liên tục từ đối phương
                //Vòng lặp này sẽ tiếp tục chạy cho đến khi có yêu cầu hủy bỏ tác vụ nền.
            }
        }

        private int isEndGame()
        {
            // Cả checkWord và ProgressBar đều ảnh hưởng đến trạng thái kết thúc
            if (checkWord() == false || (ProgressBar1.Value == ProgressBar1.Maximum)) return 0;
            else return 1;
        }

        private void EndGame(int isEndGame)
        {
            TmCoolDown.Stop(); // Stop the Timer when the game ends

            // Determine the game outcome based on score and signal the opponent
            if (isEndGame == 0) // Player has lost
            {
                byte[] gameOverSignal = { 2 }; // Send "lost" signal to opponent
                sock.Send(gameOverSignal);
                ShowLossMessage(); // Display "You Lost!" for this player
            }
            else if (isEndGame == 1)
            {
                return;
            }
        }

        private void ShowLossMessage()
        {
            TmCoolDown.Stop();
            MessageBox.Show("You Lost!");
            FreezeBoard();
            
        }

        private void ShowWinningMessage()
        {
            TmCoolDown.Stop();
            MessageBox.Show("You Win!");
            FreezeBoard();
            
        }

        private void MultiplePlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               BtnNext.PerformClick(); // Gọi sự kiện click của nút "Next"
            }
        }


        public bool checkWord()
        {
            if (Txtbword.Text.ToLower().Trim().Equals(words[index]))
            {
                LbResult.Text = "Correct";
                LbResult.BackColor = Color.Green;
                score++;
                Txtbword.Text = "";
                LbScore.Text = score.ToString();
                return true;
            }
            else
            {
                LbResult.Text = "Wrong";
                LbResult.BackColor = Color.Red;
                Txtbword.Text = "";
                LbScore.Text = score.ToString();
                return false;
            }
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
           

            // Insert blanks at the chosen positions
            word = word.Remove(pos1, 1).Insert(pos1, "_");
           

            // Display the modified word
            LabelWord.Text = word;
        }
        private void FreezeBoard()
        {
            BtnNext.Enabled = false;
            BtnStart.Enabled = false;
            Txtbword.Enabled = false;
            TmCoolDown.Enabled = false;
            isMyTurn = false;
        }

        private void UnfreezeBoard()
        {
            autoStart();
            Txtbword.Focus();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LbScore.Text = "0";
            autoStart();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TmCoolDown_Tick(object sender, EventArgs e)
        {

            if (ProgressBar1.Value < ProgressBar1.Maximum)
            {
                ProgressBar1.PerformStep(); // Tăng giá trị lên
                Txtbword.Enabled = true; // Đảm bảo ô nhập từ vẫn mở trong thời gian chạy
                Txtbword.Focus(); // Giữ focus vào ô nhập từ
            }
            else
            {
                TmCoolDown.Stop(); // Dừng Timer khi thanh ProgressBar đầy
                // Đánh dấu là sai khi hết thời gian
                LbResult.Text = "Wrong";
                LbResult.BackColor = Color.Red;
                Txtbword.Enabled = false; // Khóa lại sau khi hết lượt
                Txtbword.Text = "";
                LbScore.Text = score.ToString();
                EndGame(isEndGame()); // Kiểm tra và xử lý nếu kết thúc trò chơi
            }
        }
        private void autoStart()
        {
            LbResult.Text = "Result";
            LbResult.BackColor = Color.Ivory;

            displayword();
            TmCoolDown.Enabled = true;
            BtnNext.Enabled = true;

            BtnStart.Enabled = false; // Disable start button while in progress

            // Thiết lập giá trị ban đầu của ProgressBar
            ProgressBar1.Value = 0;
            ProgressBar1.Step = Cons.COOL_DOWN_STEP;
            ProgressBar1.Maximum = Cons.COOL_DOWN_TIME;

            // Bắt đầu Timer
            TmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL; // Thời gian cập nhật, ví dụ 100ms
            TmCoolDown.Start();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (isMyTurn)
            {
                // Check word and update score
                if (checkWord())
                {
                    
                    ProgressBar1.Value = 0;

                    
                    // Send turn signal to the opponent
                    byte[] turnSignal = { 1 };
                    sock.Send(turnSignal);

                    // Freeze board and switch turn
                    FreezeBoard();
                    isMyTurn = false;
                }
                else
                {
                    EndGame(isEndGame());
                }

                // Start MessageReceiver to listen for signals from the opponent
                if (!MessageReceiver.IsBusy)
                    MessageReceiver.RunWorkerAsync();
            }
            else
            {
                EndGame(isEndGame());
            }
        }

        private void MultiplePLayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            server?.Stop();
            sock?.Close();
            client?.Close();
        }

        private void ReceiveMove()
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);

            if (buffer[0] == 1) // Opponent's turn signal
            {
                
                isMyTurn = true;
                Invoke((MethodInvoker)delegate
                {
                    UnfreezeBoard();
                });
            }
            else if (buffer[0] == 2) // Opponent lost, so player wins
            {
                Invoke((MethodInvoker)delegate
                {
                    ShowWinningMessage(); // Display "You Win!" if opponent lost
                });
            }
            
            
        }
    }
}
