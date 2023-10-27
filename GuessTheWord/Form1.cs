using GuessTheWord.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class FormGuessTheWord : Form
    {
        string word;
        int guessCount = 0;
        int allowedGuesses = 0;
        char[] targetWord;

        private Words words = new Words();

        public FormGuessTheWord()
        {
            InitializeComponent();
            targetWord = new char[0];
        }

        private void FormGuessTheWord_Load(object sender, EventArgs e)
        {
            chooseWord();
            updateCount();
        }

        private void btnNextWord_Click(object sender, EventArgs e)
        {
            chooseWord();
            guessCount = 0;
            updateCount();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            guessCount++;
            string input = tbLetter.Text;
            char selectedLetter = char.ToUpper(input[0]);
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == selectedLetter)
                {
                    targetWord[i] = word[i];
                }
            }
            tbName.Text = String.Join(" ", targetWord);

            string targetWordStr = String.Join("", targetWord);

            if(targetWordStr != word && guessCount >= allowedGuesses)
            {
                tbName.Text = word;
                tbCheckIsCorrect.Text = "You Lost";

            } else if (targetWordStr == word)
            {
                tbName.Text = word;
                tbCheckIsCorrect.Text = "You Won";
            }

            tbLetter.Text = "";
            btnGuess.Enabled = false;
            updateCount();

        }

        private void chooseWord()
        {
            Random random = new Random();
            string[] wordArrray = words.GetWords();
            word = wordArrray[random.Next(0, wordArrray.Length)];
            char[] wordArray = word.ToCharArray();
            targetWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                targetWord[i] = '_';
            }
            tbName.Text = String.Join(" ", targetWord);
            allowedGuesses = word.Length + 5;
        }

        private void updateCount()
        {
            tbGuessesAndLetterCount.Text = guessCount + "/" + allowedGuesses;
        }

        private void tbLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && tbLetter.Text.Length == 0)
            {
                btnGuess.Enabled = true;
            }
            else
            {
                btnGuess.Enabled = false;
            }
        }
    }
}
