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
        public FormGuessTheWord()
        {
            InitializeComponent();
        }

        private void FormGuessTheWord_Load(object sender, EventArgs e)
        {

        }

        string[] words =
        {
            "PELMENIS",
            "DESA",
            "MAIZE",
            "SIERS"
        };

        char[] word;

        private void btnNextWord_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            word = words[random.Next(0, words.Length)].ToCharArray();
            tbName.Text = getTargetWord(word);
        }

        public string getTargetWord(char[] word)
        {
            string[] targetWord = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                targetWord[i] = "_";
            }
            return String.Join(" ",targetWord);
        }
    }
}
