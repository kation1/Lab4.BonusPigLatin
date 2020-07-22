using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab4.BonusPigLatin
{
    class Program
    {
        static string PigLatin(string input)
        {
            List<char> vowel = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            

            string userWord = input;
            bool punctPresent = false;
            string punctuation ="";

            if (Char.IsPunctuation(userWord[(userWord.Length-1)]))
            {
                punctuation = userWord[userWord.Length-1].ToString();
                userWord = userWord.Remove(userWord.Length-1);
                punctPresent = true;
             }
           
            
            if (vowel.Contains(userWord[0]))
            {
                userWord += "w";
            }
            else
            {
                for (int index = 0; index < input.Length; index++)

                {
  
                    if (!vowel.Contains(userWord[0]))
                    {
                        userWord += userWord[0];
                        userWord = userWord.Remove(0, 1);
                    }

                }
            }

            userWord += "ay";
            if (punctPresent == true)
            {
                userWord += punctuation;
            }


            return userWord;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            string userCont = "y";
            while (userCont != "n")
            {

                Console.WriteLine("Enter a line to be translated:");
                string userInput = Console.ReadLine();
                string userPhrase = userInput.ToLower();
               //tring userPhrase = Console.ReadLine();


                string[] words = userPhrase.Split(' ');
                string pigPhrase = "";
                char punctuation = ' ';
                foreach (string word in words)
                {
                        
                        pigPhrase += PigLatin(word) + " ";
                   
                }
                Console.WriteLine(pigPhrase);



                Console.WriteLine("Do you want to go again?");
                userCont = Console.ReadLine();
            }
        }
    }
}
