using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001.TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int winX = 0;
        public int winO = 0;
        public int draws = 0;
        public int count = 0;

        Button button;

        private void ButtonClick(object sender, EventArgs e)
        {
            button = (Button)sender;

            //calculate the turns
            if (button.Text == "")
            {
                if (count % 2 == 0)
                {
                    if (player % 2 == 0)
                    {
                        button.Text = "X";
                        player++;
                        turns++;
                    }
                    else
                    {
                        button.Text = "O";
                        player++;
                        turns++;
                    }
                }
                else
                {
                    if (player % 2 == 0)
                    {
                        button.Text = "O";
                        player++;
                        turns++;
                    }
                    else
                    {
                        button.Text = "X";
                        player++;
                        turns++;
                    }
                }

                //show images
                if (A00.Text == "X") //A00
                    pBoxXA00.Visible = true;
                else if (A00.Text == "O")
                    pBoxOA00.Visible = true;
                if (A01.Text == "X") //A01
                    pBoxXA01.Visible = true;
                else if (A01.Text == "O")
                    pBoxOA01.Visible = true;
                if (A02.Text == "X") //A02
                    pBoxXA02.Visible = true;
                else if (A02.Text == "O")
                    pBoxOA02.Visible = true;
                if (A10.Text == "X") //A10
                    pBoxXA10.Visible = true;
                else if (A10.Text == "O")
                    pBoxOA10.Visible = true;
                if (A11.Text == "X") //A11
                    pBoxXA11.Visible = true;
                else if (A11.Text == "O")
                    pBoxOA11.Visible = true;
                if (A12.Text == "X") //A12
                    pBoxXA12.Visible = true;
                else if (A12.Text == "O")
                    pBoxOA12.Visible = true;
                if (A20.Text == "X") //A20
                    pBoxXA20.Visible = true;
                else if (A20.Text == "O")
                    pBoxOA20.Visible = true;
                if (A21.Text == "X") //A21
                    pBoxXA21.Visible = true;
                else if (A21.Text == "O")
                    pBoxOA21.Visible = true;
                if (A22.Text == "X") //A22
                    pBoxXA22.Visible = true;
                else if (A22.Text == "O")
                    pBoxOA22.Visible = true;

                //check the game for draw
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Играта е равна!" , "Tic Tac Toe");
                    draws++;
                    NewGame();
                }

                if (CheckWinner() == true) //check the winner
                {
                    if (button.Text == "X") //winner X
                    {
                        MessageBox.Show(playerX.Text + " печели", "Tic Tac Toe");
                        winX++;
                        NewGame();
                    }
                    else //winner O
                    {
                        MessageBox.Show(playerO.Text + " печели", "Tic Tac Toe");
                        winO++;
                        NewGame();
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //exit button
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //stats on wins and draws
            XWins.Text = "" + winX;
            OWins.Text = "" + winO;
            Draw.Text = "" + draws;
            inputNameX.Focus();
        }

        void NewGame() //new game
        {
            count++;
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";

            //update the wins and draws
            XWins.Text = "" + winX;
            OWins.Text = "" + winO;
            Draw.Text = "" + draws;
            
            //hide images
            pBoxXA00.Visible = false;
            pBoxOA00.Visible = false;
            pBoxXA01.Visible = false;
            pBoxOA01.Visible = false;
            pBoxXA02.Visible = false;
            pBoxOA02.Visible = false;
            pBoxXA10.Visible = false;
            pBoxOA10.Visible = false;
            pBoxXA11.Visible = false;
            pBoxOA11.Visible = false;
            pBoxXA12.Visible = false;
            pBoxOA12.Visible = false;
            pBoxXA20.Visible = false;
            pBoxOA20.Visible = false;
            pBoxXA21.Visible = false;
            pBoxOA21.Visible = false;
            pBoxXA22.Visible = false;
            pBoxOA22.Visible = false;
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            //start new game when button is clicked
            NewGame();
        }

        //check the game for draw
        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check the winner
        bool CheckWinner()
        {
            //horizontal checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
            {
                return true;
            }
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
            {
                return true;
            }
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
            {
                return true;
            }

            //vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
            {
                return true;
            }
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
            {
                return true;
            }
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
            {
                return true;
            }

            // diagonals checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
            {
                return true;
            }
            else if ((A20.Text == A11.Text) && (A11.Text == A02.Text) && A02.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            //delete button
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playerX.Text = inputNameX.Text;
            playerO.Text = inputNameO.Text;
            startPanel.Visible = false;
        }

        private void startPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void inputNameO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playerX.Text = inputNameX.Text;
                playerO.Text = inputNameO.Text;
                startPanel.Visible = false;
            }
        }

        private void inputNameX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputNameO.Focus();
            }
        }
    }
}
