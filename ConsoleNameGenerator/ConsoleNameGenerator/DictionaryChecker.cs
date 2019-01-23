using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNameGenerator
{
    class DictionaryChecker
    {
        internal static void DisplayDictionary(Dictionary<char,HashSet<string>> _dictionary)
        {
            foreach (var _pair in _dictionary)
            {
                Console.WriteLine("Options for {0} are:", _pair.Key);

                foreach (var _value in _pair.Value)
                {
                    Console.WriteLine(_value);
                }
            }
           
        }
    }
}
