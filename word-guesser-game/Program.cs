using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace word_guesser_game
{
    internal class Program
    {
        static async Task<string[]> GetWordsAsync()
        {
            using HttpClient client = new HttpClient();
            string url = "https://random-word-api.herokuapp.com/word?number=5";
            string response = await client.GetStringAsync(url);
            return System.Text.Json.JsonSerializer.Deserialize<string[]>(response);
        }
        static void Game(int maxLives, int currentLives, bool win, string secretWord, List<char> guessedLetters)
        {
            while (currentLives > 0 && !win)
            {
                foreach (char c in secretWord)
                {
                    if (guessedLetters.Contains(c))
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }

                Console.WriteLine($"\nLives remaining:{currentLives}/{maxLives}");
                try
                {
                    Console.Write($"Please guess a letter: ");
                    char guess = Convert.ToChar(Console.ReadLine());
                    if (secretWord.Contains(guess) && !guessedLetters.Contains(guess))
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        currentLives--;
                    }

                    guessedLetters.Add(guess);

                    bool wordComplete = true;
                    foreach (char c in secretWord)
                    {
                        if (!guessedLetters.Contains(c))
                        {
                            wordComplete = false;
                        }
                    }

                    win = wordComplete;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Enter only one letter.");
                }

            }

        }
        static async Task Main(string[] args)
        {
            Random rnd = new Random();
            string[] words = await GetWordsAsync();
            string secretWord = words[rnd.Next(words.Length)];

            int maxLives = 10;
            int currentLives = maxLives;

            bool win = false;
            bool playAgain = false;
            List<char> guessedLetters = new List<char>();

            do
            {
                Game(maxLives, currentLives, win, secretWord, guessedLetters);
                if (win)
                {
                    Console.WriteLine("Congratulations, you win!");
                }
                else
                {
                    Console.WriteLine($"You lost. The secret word was '{secretWord}'.");
                    Console.Write("Do you want to play again? (type:'y' for yes, 'n' for no) : ");
                    if (Console.ReadLine() == "y")
                    {
                        playAgain = true;
                        secretWord = words[rnd.Next(words.Length)];
                        currentLives = maxLives;
                        win = false;
                        guessedLetters.Clear();
                    }
                    else
                    {
                        Environment.Exit(0); 
                    }
                }
            } while (playAgain);

            Console.ReadKey();
        }
    }
}
