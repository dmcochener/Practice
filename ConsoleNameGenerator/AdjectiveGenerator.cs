using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleNameGenerator
{
    public class AdjectiveGenerator
    {
        public static string GetAdjective(char letter, Dictionary<char,HashSet<string>> _adjDictionary, Random RanDom)
        {
            string adj = "Exceptional";
            if (_adjDictionary.TryGetValue(letter, out HashSet<string> possibles))
            {
                int optionsNum = possibles.Count;
                string[] adjList = new string[optionsNum];
                int i = RanDom.Next(adjList.Length);
                possibles.CopyTo(adjList);
                adj = adjList[i];
            }
            return adj;
        }
    }
}