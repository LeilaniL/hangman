using System.Collections.Generic;
using System;

namespace HangMan.Models
{
    public class Guess
    {
        private char _userGuess;
        private int _attemptNumber;
        public Guess(char userGuess)
        {
            _userGuess = userGuess;
        }
        public char GetGuess()
        {
            return _userGuess;
        }
        public int GetAttemptNumber()
        {
            return _attemptNumber;
        }
        public bool IsGameOver()
        {
            if (_attemptNumber > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int noOfGuesses = 0;
        public List<Char> rightAnswer = new List<Char> { 't', 'e', 's', 't' }; s
        public List<Char> guessedLetters = new List<Char> { '_', '_', '_', '_' };
        public List<Char> CheckForMatch(char userInput)
        {
            for (int i = 0; i < rightAnswer.Count; i++)
            {
                if (rightAnswer[i] == userInput)
                {
                    guessedLetters[i] = userInput;
                }
                else
                {
                    Console.WriteLine("Wrong Guess");
                    noOfGuesses++;

                }
            }
            return guessedLetters;
        }

    }
    class Program
    {
        public static void Main()
        {
            int ConsoleAttemptNumber = 1;
            while (noOfGuesses <= 6)
            {
                Console.WriteLine("Guess a Letter:");
                char letter = Console.ReadKey().KeyChar;
                Guess newGuess = new Guess(letter);
                ConsoleAttemptNumber++;
                // char res = letter.ToChar();

                for (int i = 0; i < newGuess.rightAnswer.Count; i++)
                {
                    newGuess.CheckForMatch(letter);
                }
                foreach (char character in newGuess.guessedLetters)
                {
                    Console.WriteLine(character);
                }
            }

        }
    }
}
