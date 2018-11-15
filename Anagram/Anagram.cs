using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input a Word:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Input a word to test for Anagrams:");
            
            List<string> userList = new List<string> {};
            List<string> anagramList = new List<string> {};
            
            string tempString = Console.ReadLine();
            userList.Add(tempString);
            Console.WriteLine("Do you want to add another word to the list? (Y/N)");
            string tempAnswer = Console.ReadLine();
            while (tempAnswer == "Y" || tempAnswer == "y")
            {
                Console.WriteLine("Enter a word to add to the list: ");
                tempString = Console.ReadLine();
                userList.Add(tempString);
                Console.WriteLine("Do you want to add another word to the list? (Y/N)");
                tempAnswer = Console.ReadLine();
            }
            CalculateAnagram myAnagram = new CalculateAnagram();
            foreach (string listString in userList)
            {
                // bool ifTrue = IsAnagram(userInput, listString);
                if (myAnagram.IsAnagram(userInput, listString))
                {
                anagramList.Add(listString);
                }
            }
            Console.WriteLine("These are the words that you entered that are Anagrams.");
            foreach (string finalString in anagramList)
            {
                Console.WriteLine(finalString);
            }
        }
    }

    public class CalculateAnagram
    {
        public bool IsAnagram(string userInput, string fromList)
        {
            char[] arrayOne = userInput.ToCharArray();
            char[] arrayTwo = fromList.ToCharArray();

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            return arrayOne.SequenceEqual(arrayTwo);
        }
    }
}