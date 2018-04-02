using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001.Hangman
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            //ban write text in textboxs
            //screen2.Enabled = false;
            historyChars.Enabled = false;
            printWord_.Enabled = false;
            screen.Visible = false;

            //focus on text box for input word - textInputWord
            this.ActiveControl = textInputWord;
            textInputWord.Focus();

            //Message with game rule
            MessageBox.Show(@"Правила на играта:
1. Въведете дума на кирилица или латиница от 3 до 10 букви!
2. Въвеждате по една буква всеки път за да се опитате 
да познаете думата!
3. Ако смятате, че сте познали думата въведете я цялата, 
ако не познаете ще се зачете за грешка!
4. Имате право на 5 грешки като при 6-тата губите играта!
                     ПРИЯТНА ИГРА !!!
            ", " ------ ПРАВИЛА ------    Created By Stoyan Petkov!");
        }

        //List for chars word
        List<char> wordInChar = new List<char>();
        //List for inputed chars
        List<char> inputChar = new List<char>();
        //Array where guest chars are save 
        string[] wordArr = new string[] { };

        int wrongs = 0;

        bool checkForNumbers = false;
        bool wr = false;
        bool won = false;
        bool error = false;

        private void textInputWord_TextChanged(object sender, EventArgs e)
        {
            //textInputWord
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deleted button 
        }

        private void buttonInputWord_Click(object sender, EventArgs e)
        {
            //check for value string input != from int

            //set the checker for "false"
            checkForNumbers = false;

            foreach (char item in textInputWord.Text)
            {
                if (char.IsDigit(item))
                {
                    //if in textInputWord.Text set the checker "true"
                    checkForNumbers = true;
                }
            }
            
            if (checkForNumbers == true)
            {
                MessageBox.Show("Въвели сте число! \n" +
                    "Моля въведи буква!", " Грешка !");
                textInputWord.Clear();
                textInputWord.Focus();
            }
            else if (Convert.ToString(textInputWord.Text) == "")
            {
                MessageBox.Show("Не си въвел дума! \n" +
                    "Въведи дума от 3 до 10 букви!", " Грешка !");
                textInputWord.Focus();
            }
            else if (textInputWord.Text.Length < 3)
            {
                MessageBox.Show("Въвели сте дума по малко от 3 букви! \n" +
                    "Въведи дума от 3 до 10 букви!", " Грешка !");
                textInputWord.Focus();
            }
            else
            {
                //input the secret word
                textInputWord.Text = textInputWord.Text.ToLower();
                wordArr = new string[textInputWord.Text.Length];

                //Convert the secret word in chars
                for (int i = 0; i < textInputWord.Text.Length; i++)
                {
                    wordInChar.Add(textInputWord.Text[i]);
                    wordArr[i] = "_";

                    //hide text box for input word
                    textInputWord.Visible = false;
                    buttonInputWord.Visible = false;
                    label5.Visible = false;
                    panel2.Visible = false;

                    //first print
                    screen2.Text = @"______
|    |
|   
|   
|   
|";
                }
            }
        }

        private void historyChars_TextChanged(object sender, EventArgs e)
        {
            //historyChars
        }

        private void charInput_TextChanged(object sender, EventArgs e)
        {
            //charInput
        }

        private void buttonCheckChar_Click(object sender, EventArgs e)
        {
            //buttonCheckChar

            //add input chars in inputChar list for save them
            for (int y = 0; y < 1; y++)
            {
                //catch errors
                //set the checker for "false"
                checkForNumbers = false;
                foreach (char item in txtInputChar.Text)
                {
                    if (char.IsDigit(item))
                    {
                        //if in textInputWord.Text set the checker "true"
                        checkForNumbers = true;
                    }
                }

                if (checkForNumbers == true)
                {
                    MessageBox.Show("Въвели сте числа! \n" +
                        "Моля въведи дума от 3 до 10 букви!", " Грешка !");
                    txtInputChar.Clear();
                    txtInputChar.Focus();
                    break;
                }

                try
                {
                    wr = false;
                    txtInputChar.Text = txtInputChar.Text.ToLower();
                    inputChar.Add(txtInputChar.Text[0]);
                    error = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не си въвел буква или дума!", "Грешка!");
                    error = true;
                    txtInputChar.Focus();
                }

                //check wardArr if secret word is guess - game end with victory
                for (int i = 0; i < wordArr.Length; i++)
                {
                    if (wordArr[i] != "_")
                    {
                        won = true;
                    }
                    else
                    {
                        won = false;
                        break;
                    }
                }

                if (txtInputChar.Text == textInputWord.Text || won == true)
                {
                    MessageBox.Show("Поздравления, ти позна тайната дума!", "Победа!");

                    //show panel for input new secret word
                    textInputWord.Visible = true;
                    buttonInputWord.Visible = true;
                    label5.Visible = true;
                    panel2.Visible = true;

                    //restart all values
                    textInputWord.Clear();
                    printWord_.Clear();
                    historyChars.Clear();
                    txtInputChar.Clear();
                    wordInChar = new List<char>();
                    inputChar = new List<char>();
                    wrongs = 0;

                    //focus on text box for input word - textInputWord
                    this.ActiveControl = textInputWord;
                    textInputWord.Focus();
                    break;
                }

                //check the input char in secret word
                for (int i = 0; i < wordInChar.Count; i++)
                {
                    if (error == true)
                    {
                        break;
                    }
                    if (txtInputChar.Text[0] == wordInChar[i])
                    {
                        wordArr[i] = Convert.ToString(txtInputChar.Text[0]);
                        wr = true;
                        //print if the char is in the secret word
                        switch (i)
                        {
                            case 0:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0];
                                }
                                break;
                            case 1:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " ";
                                }
                                break;
                            case 2:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " ";
                                }
                                break;
                            case 3:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " ";
                                }
                                break;
                            case 4:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4] + " ";
                                }
                                break;
                            case 5:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " ";
                                }
                                break;
                            case 6:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " ";
                                }
                                break;
                            case 7:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " ";
                                }
                                break;
                            case 8:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " " + wordArr[8] + " ";
                                }
                                break;
                            case 9:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " " + wordArr[8] + " " + wordArr[9] + " ";
                                }
                                break;
                            case 10:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " " + wordArr[8] + " " + wordArr[9] + " "
                                        + wordArr[10] + " ";
                                }
                                break;
                            default:

                                break;
                        }
                    }
                    else
                    {
                        //print if don't have char in the secret word
                        switch (i)
                        {
                            case 0:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0];
                                }
                                break;
                            case 1:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " ";
                                }
                                break;
                            case 2:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " ";
                                }
                                break;
                            case 3:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " ";
                                }
                                break;
                            case 4:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4] + " ";
                                }
                                break;
                            case 5:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " ";
                                }
                                break;
                            case 6:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " ";
                                }
                                break;
                            case 7:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " ";
                                }
                                break;
                            case 8:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " " + wordArr[8] + " ";
                                }
                                break;
                            case 9:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " " + wordArr[8] + " " + wordArr[9] + " ";
                                }
                                break;
                            case 10:
                                printWord_.Clear();
                                if (i < wordInChar.Count)
                                {
                                    printWord_.Text = wordArr[0] + " " + wordArr[1] + " " + wordArr[2] + " " + wordArr[3] + " " + wordArr[4]
                                        + " " + wordArr[5] + " " + wordArr[6] + " " + wordArr[7] + " " + wordArr[8] + " " + wordArr[9] + " "
                                        + wordArr[10] + " ";
                                }
                                break;
                            default:
                                break;
                        }
                    }

                    //clear historyChars in the games to be ready for the new history
                    historyChars.Clear();
                }

                //wrongs count
                if (wr == false)
                {
                    wrongs++;
                    wr = true;
                }
                //print historyChars - inputs chars in the game
                foreach (var x in inputChar)
                {
                    //if input nothing and have error don't print history chars
                    if (error == true)
                    {
                        break;
                    }
                    historyChars.Text = historyChars.Text + " " + x;
                }

                //clear the input char 
                txtInputChar.Clear();

                //print wrongs in pictures
                if (wrongs == 0)
                {
                    screen2.Text = @"______
|    |
|   
|   
|   
|";
                }
                else if (wrongs == 1)
                {
                    screen2.Text = @"______
|    |
|    O
|   
|   
|";
                }
                else if (wrongs == 2)
                {
                    screen2.Text = @"______
|    |
|    O
|   /
|   
|";
                }
                else if (wrongs == 3)
                {
                    screen2.Text = @"______
|    |
|    O
|   /|
|   
|";
                }
                else if (wrongs == 4)
                {
                    screen2.Text = @"______
|    |
|    O
|   /|\
|   
|";
                }
                else if (wrongs == 5)
                {
                    screen2.Text = @"______
|    |
|    O
|   /|\
|   /
|";
                }
                else if (wrongs == 6)
                {
                    screen2.Text = @"______
|    |
|    O
|   /|\
|   / \
|";
                    MessageBox.Show("Вие губите, не успяхте да познаете тайната дума: \""
                        + textInputWord.Text + "\"!", "Game Over");

                    //show panel for input new secret word
                    textInputWord.Visible = true;
                    buttonInputWord.Visible = true;
                    label5.Visible = true;
                    panel2.Visible = true;

                    //restart all values
                    textInputWord.Clear();
                    printWord_.Clear();
                    historyChars.Clear();
                    txtInputChar.Clear();
                    wordInChar = new List<char>();
                    inputChar = new List<char>();
                    wrongs = 0;

                    //focus on text box for input word - textInputWord
                    this.ActiveControl = textInputWord;
                    textInputWord.Focus();
                    break;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textInputWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //check for numbers

                //set the checker for "false"
                checkForNumbers = false;

                foreach (char item in textInputWord.Text)
                {
                    if (char.IsDigit(item))
                    {
                        //if in textInputWord.Text set the checker "true"
                        checkForNumbers = true;
                    }
                }

                if (checkForNumbers == true)
                {
                    MessageBox.Show("Въвели сте число! \n" +
                        "Моля въведи дума от 3 до 10 букви!", " Грешка !");
                    textInputWord.Clear();
                    textInputWord.Focus();
                }
                else if (Convert.ToString(textInputWord.Text) == "")
                {
                    MessageBox.Show("Не си въвел дума! \n" +
                        "Въведи дума от 3 до 10 букви!", " Грешка !");
                    textInputWord.Clear();
                    textInputWord.Focus();
                }
                else if (textInputWord.Text.Length < 3)
                {
                    MessageBox.Show("Въвели сте дума по малко от 3 букви! \n" +
                        "Въведи дума от 3 до 10 букви!", " Грешка !");
                    textInputWord.Clear();
                    textInputWord.Focus();
                }
                else
                {
                    buttonInputWord.PerformClick();
                }
            }
        }

        private void txtInputChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCheckChar.PerformClick();
            }
        }
    }
}