using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine().ToUpper();
            char[] userNameArray = userName.ToCharArray();

            Random NewRan = new Random();
            var DictInstance = new DictionaryCreator();
            DictInstance.InitializeDictionary();
            Dictionary<char, HashSet<string>> AdjectiveDict = DictInstance.FinalDictionary;

            foreach (char letter in userNameArray)
            {
                string adjective = AdjectiveGenerator.GetAdjective(letter, AdjectiveDict, NewRan);
                Console.WriteLine(adjective);
            }

            Console.WriteLine("Press 'D' to view possibles adjectives and any key to close app");
            var _key = Console.ReadKey();
            if (_key.Key == ConsoleKey.D)
            {
                DictionaryChecker.DisplayDictionary(AdjectiveDict);
                Console.WriteLine("Press any key to close app");
                Console.ReadKey();
            } 

        }


    }
}
