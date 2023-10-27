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
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(46, 40);
            this.tbName.MaximumSize = new System.Drawing.Size(500, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(350, 56);
            this.tbName.TabIndex = 0;
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(46, 117);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(350, 56);
            this.tbLetter.TabIndex = 1;
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
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(46, 194);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(350, 79);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            // 
            // tbCheckIsCorrect
            // 
            this.tbCheckIsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckIsCorrect.Location = new System.Drawing.Point(46, 388);
            this.tbCheckIsCorrect.Name = "tbCheckIsCorrect";
            this.tbCheckIsCorrect.Size = new System.Drawing.Size(350, 56);
            this.tbCheckIsCorrect.TabIndex = 4;
            // 
            // tbGuessesAndLetterCount
            // 
            this.tbGuessesAndLetterCount.BackColor = System.Drawing.SystemColors.Control;
            this.tbGuessesAndLetterCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGuessesAndLetterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuessesAndLetterCount.Location = new System.Drawing.Point(46, 477);
            this.tbGuessesAndLetterCount.Name = "tbGuessesAndLetterCount";
            this.tbGuessesAndLetterCount.Size = new System.Drawing.Size(350, 37);
            this.tbGuessesAndLetterCount.TabIndex = 5;
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

