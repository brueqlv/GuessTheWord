namespace GuessTheWord
{
    partial class FormGuessTheWord
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.tbCheckIsCorrect = new System.Windows.Forms.TextBox();
            this.tbGuessesAndLetterCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(46, 40);
            this.tbName.MaximumSize = new System.Drawing.Size(500, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(350, 49);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLetter
            // 
            this.tbLetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(46, 117);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(350, 49);
            this.tbLetter.TabIndex = 1;
            this.tbLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLetter_KeyPress);
            // 
            // btnNextWord
            // 
            this.btnNextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWord.Location = new System.Drawing.Point(46, 294);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(350, 79);
            this.btnNextWord.TabIndex = 2;
            this.btnNextWord.Text = "Next Word";
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(46, 194);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(350, 79);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // tbCheckIsCorrect
            // 
            this.tbCheckIsCorrect.BackColor = System.Drawing.SystemColors.Menu;
            this.tbCheckIsCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCheckIsCorrect.Enabled = false;
            this.tbCheckIsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckIsCorrect.Location = new System.Drawing.Point(46, 461);
            this.tbCheckIsCorrect.Name = "tbCheckIsCorrect";
            this.tbCheckIsCorrect.Size = new System.Drawing.Size(350, 49);
            this.tbCheckIsCorrect.TabIndex = 4;
            this.tbCheckIsCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGuessesAndLetterCount
            // 
            this.tbGuessesAndLetterCount.BackColor = System.Drawing.SystemColors.Control;
            this.tbGuessesAndLetterCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGuessesAndLetterCount.Enabled = false;
            this.tbGuessesAndLetterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuessesAndLetterCount.Location = new System.Drawing.Point(46, 392);
            this.tbGuessesAndLetterCount.Name = "tbGuessesAndLetterCount";
            this.tbGuessesAndLetterCount.Size = new System.Drawing.Size(350, 37);
            this.tbGuessesAndLetterCount.TabIndex = 5;
            this.tbGuessesAndLetterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormGuessTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 558);
            this.Controls.Add(this.tbGuessesAndLetterCount);
            this.Controls.Add(this.tbCheckIsCorrect);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.tbName);
            this.Name = "FormGuessTheWord";
            this.Text = "GuessTheWord";
            this.Load += new System.EventHandler(this.FormGuessTheWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox tbCheckIsCorrect;
        private System.Windows.Forms.TextBox tbGuessesAndLetterCount;
    }
}

