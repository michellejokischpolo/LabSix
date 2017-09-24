using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>() { 'a', 'o', 'e', 'u', 'i' }; // a list is like an array with predefined methods to call 
            Console.WriteLine("Welcome to the PiG LaTiN Translator!");
            Console.WriteLine("Enter a line to be translated:");
            string word1 = Console.ReadLine(); // first word input by user
            Console.WriteLine(word1.ToLowerInvariant() + " will be translated to Pig Latin"); //puts the words input by user in  lower case
            char firstLetter; // creates a new variable called first letter
            firstLetter = word1.ToCharArray()[0]; // an array character of each letter in the word the user gave    
            if (vowels.Contains(firstLetter)) // asks if the list of vowels above can be found within the array of letters the user gave
            {
                word1 += "way"; // adds way to word1 
                Console.WriteLine(word1);
            }
            else // consonant
            {
                char[] wordCharArray = word1.ToCharArray();  // convers into separate characters the word given by the user
                string consonantsbeforefirstvowel = ""; // string of consonants in the array given by the user as consonants before first vowel found
                string finalWord = "";// final word
                foreach (char c in wordCharArray) // the separated charactesr are stored in c 
                {
                    if (!vowels.Contains(c)) // c does not contain vowels in the first letter 
                    {
                        consonantsbeforefirstvowel += c; 
                    }
                    else
                    {
                        int vowellocation = word1.IndexOf(c); // returns an integer to replace where the location of the vowel was
                        int length = word1.Length - vowellocation; // the entire length of the word minus how far you have already gone
                        finalWord = word1.Substring(vowellocation, length); // start where the vowel is and go the length defined above 
                        finalWord += consonantsbeforefirstvowel;
                        finalWord += "ay";
                        break;
                    }
                }
                Console.WriteLine(finalWord);
            }

            Console.ReadLine();
        }

    }
}


               