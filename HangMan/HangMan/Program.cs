using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            HangMan();
            Console.ReadKey();
        }

        static void HangMan()
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + " . You will be guessing letters of a word until you can guess the word or all of the letters");

            string[] wordList = new string[30] { "attack", "belief", "birth", "comfort", "cork", "desire", "distribution", "earth", "experience", "feeling", "fold", "government", "humour", 
                "insect", "knowledge", "learning", "manager", "nation", "observation", "paper", "question", "reason", "science", "thunder", "unit", "vocabulary", "wishing", "xylophone", "yellow", "zebra"};

            Random r = new Random();
            string word = wordList[r.Next(0, wordList.Length)];
            for (int i = 0; i <= word.Length; i++)
            {
                Console.Write("_ ", word.Length);
            }
        }
    }
}
