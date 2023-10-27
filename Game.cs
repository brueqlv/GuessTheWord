using System;

public class Game
{
    public class Game()
    {
        private string[] words = { "PELMENIS", "DESA", "MAIZE", "SIERS" };
        private string word;
        private char[] targetWord;
        private int guessCount;
        private int allowedGuesses;

        public void InitializeGame()
        {
            StartNewRound();
        }

        public void StartNewRound()
        {
            Random random = new Random();
            word = words[random.Next(0, words.Length)].ToUpper();
            targetWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                targetWord[i] = '_';
            }
            guessCount = 0;
            allowedGuesses = word.Length + 5;
        }

        public void MakeGuess(char guessedLetter)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guessedLetter)
                {
                    targetWord[i] = guessedLetter;
                }
            }
            guessCount++;
        }

        public string GetDisplayWord()
        {
            return new string(targetWord);
        }

        public string GetGameResult()
        {
            string targetWordStr = new string(targetWord);
            if (targetWordStr == word)
            {
                return "You Won";
            }
            if (guessCount >= allowedGuesses)
            {
                return "You Lost";
            }
            return "";
        }

        public string GetGuessesAndLetterCount()
        {
            return $"{guessCount}/{allowedGuesses}";
        }

        public bool IsGuessButtonEnabled()
        {
            return !string.IsNullOrEmpty(tbLetter.Text) && tbLetter.Text.Length == 1;
        }
    }
}
