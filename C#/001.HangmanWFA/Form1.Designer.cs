namespace _001.Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.TextBox();
            this.textInputWord = new System.Windows.Forms.TextBox();
            this.buttonInputWord = new System.Windows.Forms.Button();
            this.printWord_ = new System.Windows.Forms.TextBox();
            this.historyChars = new System.Windows.Forms.TextBox();
            this.txtInputChar = new System.Windows.Forms.TextBox();
            this.buttonCheckChar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.screen2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(230)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 28);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "За \"Изход\" натисни тук";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game - Hangman                                                              Creat" +
    "ed by Stoyan Petkov";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Black;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen.Cursor = System.Windows.Forms.Cursors.No;
            this.screen.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screen.ForeColor = System.Drawing.Color.Maroon;
            this.screen.Location = new System.Drawing.Point(202, 307);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(241, 278);
            this.screen.TabIndex = 1;
            this.screen.Visible = false;
            // 
            // textInputWord
            // 
            this.textInputWord.BackColor = System.Drawing.Color.Black;
            this.textInputWord.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.textInputWord.ForeColor = System.Drawing.Color.White;
            this.textInputWord.Location = new System.Drawing.Point(245, 134);
            this.textInputWord.MaxLength = 10;
            this.textInputWord.Name = "textInputWord";
            this.textInputWord.Size = new System.Drawing.Size(134, 32);
            this.textInputWord.TabIndex = 2;
            this.textInputWord.TextChanged += new System.EventHandler(this.textInputWord_TextChanged);
            this.textInputWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textInputWord_KeyDown);
            // 
            // buttonInputWord
            // 
            this.buttonInputWord.BackColor = System.Drawing.Color.Black;
            this.buttonInputWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInputWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputWord.ForeColor = System.Drawing.Color.White;
            this.buttonInputWord.Location = new System.Drawing.Point(245, 172);
            this.buttonInputWord.Name = "buttonInputWord";
            this.buttonInputWord.Size = new System.Drawing.Size(134, 32);
            this.buttonInputWord.TabIndex = 3;
            this.buttonInputWord.Text = "Въведи";
            this.buttonInputWord.UseVisualStyleBackColor = false;
            this.buttonInputWord.Click += new System.EventHandler(this.buttonInputWord_Click);
            // 
            // printWord_
            // 
            this.printWord_.BackColor = System.Drawing.Color.Black;
            this.printWord_.Cursor = System.Windows.Forms.Cursors.No;
            this.printWord_.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.printWord_.ForeColor = System.Drawing.Color.White;
            this.printWord_.Location = new System.Drawing.Point(239, 131);
            this.printWord_.Name = "printWord_";
            this.printWord_.ReadOnly = true;
            this.printWord_.Size = new System.Drawing.Size(333, 32);
            this.printWord_.TabIndex = 4;
            // 
            // historyChars
            // 
            this.historyChars.BackColor = System.Drawing.Color.Black;
            this.historyChars.Cursor = System.Windows.Forms.Cursors.No;
            this.historyChars.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyChars.ForeColor = System.Drawing.Color.White;
            this.historyChars.Location = new System.Drawing.Point(239, 191);
            this.historyChars.Name = "historyChars";
            this.historyChars.ReadOnly = true;
            this.historyChars.Size = new System.Drawing.Size(333, 32);
            this.historyChars.TabIndex = 5;
            this.historyChars.TextChanged += new System.EventHandler(this.historyChars_TextChanged);
            // 
            // txtInputChar
            // 
            this.txtInputChar.BackColor = System.Drawing.Color.Black;
            this.txtInputChar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtInputChar.ForeColor = System.Drawing.Color.White;
            this.txtInputChar.Location = new System.Drawing.Point(239, 251);
            this.txtInputChar.Name = "txtInputChar";
            this.txtInputChar.Size = new System.Drawing.Size(160, 32);
            this.txtInputChar.TabIndex = 6;
            this.txtInputChar.TextChanged += new System.EventHandler(this.charInput_TextChanged);
            this.txtInputChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputChar_KeyDown);
            // 
            // buttonCheckChar
            // 
            this.buttonCheckChar.BackColor = System.Drawing.Color.Black;
            this.buttonCheckChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckChar.ForeColor = System.Drawing.Color.White;
            this.buttonCheckChar.Location = new System.Drawing.Point(405, 251);
            this.buttonCheckChar.Name = "buttonCheckChar";
            this.buttonCheckChar.Size = new System.Drawing.Size(167, 32);
            this.buttonCheckChar.TabIndex = 7;
            this.buttonCheckChar.Text = "Провери";
            this.buttonCheckChar.UseVisualStyleBackColor = false;
            this.buttonCheckChar.Click += new System.EventHandler(this.buttonCheckChar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(248, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Въведени букви:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(449, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "--- Бесило ---";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(248, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Въведи буква или дума:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Въведи дума:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(248, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тайна дума:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonInputWord);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textInputWord);
            this.panel2.Location = new System.Drawing.Point(12, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 329);
            this.panel2.TabIndex = 13;
            // 
            // screen2
            // 
            this.screen2.AutoSize = true;
            this.screen2.BackColor = System.Drawing.Color.Transparent;
            this.screen2.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screen2.ForeColor = System.Drawing.Color.Yellow;
            this.screen2.Location = new System.Drawing.Point(38, 33);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(0, 51);
            this.screen2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCheckChar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInputChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.historyChars);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printWord_);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.screen2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.TextBox textInputWord;
        private System.Windows.Forms.Button buttonInputWord;
        private System.Windows.Forms.TextBox printWord_;
        private System.Windows.Forms.TextBox historyChars;
        private System.Windows.Forms.TextBox txtInputChar;
        private System.Windows.Forms.Button buttonCheckChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label screen2;
    }
}

