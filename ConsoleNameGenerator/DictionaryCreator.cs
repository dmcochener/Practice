using System;
using System.Collections.Generic;

namespace ConsoleNameGenerator
{
    internal class DictionaryCreator
    {
        internal Dictionary<char, HashSet<string>> FinalDictionary { get; set; } = new Dictionary<char, HashSet<string>>();
        internal Dictionary<char, string[]> StartingDictionary { get; set; } = new Dictionary<char, string[]>();

        internal void InitializeDictionary()
        {
            StartingDictionary.Add('A', new string[] { "Amazing", "Athletic", "Artsy" });
            StartingDictionary.Add('B', new string[] { "Beautiful", "Bold", "Bright" });
            StartingDictionary.Add('C', new string[] { "Carefree", "Courteous", "Cool" });
            StartingDictionary.Add('D', new string[] { "Delightful", "Devious", "Daring", "Demure" });
            StartingDictionary.Add('E', new string[] { "Energetic", "Exciting" });
            StartingDictionary.Add('F', new string[] { "Friendly", "Fashionable", "Frightening" });
            StartingDictionary.Add('G', new string[] { "Gentle", "Generous", "Gregarious", "Giant" });
            StartingDictionary.Add('H', new string[] { "Hilarious", "Helpful", "High-Strung" });
            StartingDictionary.Add('I', new string[] { "Ingenious", "Intelligent", "Industrious" });
            StartingDictionary.Add('J', new string[] { "Jealous", "Jumpy" });
            StartingDictionary.Add('K', new string[] { "Kind", "Knowledgeable" });
            StartingDictionary.Add('L', new string[] { "Loyal", "Loving", "Late", "Lithe", "Lethargic" });
            StartingDictionary.Add('M', new string[] { "Mean", "Magical", "Messy", "Musical" });
            StartingDictionary.Add('N', new string[] { "Noisy", "Neat", "Nasty", "Nervous", "Normal" });
            StartingDictionary.Add('O', new string[] { "Open", "Outgoing", "Outstanding", "Obnoxious" });
            StartingDictionary.Add('P', new string[] { "Precious", "Pensive", "Perfect", "Perky", "Pleasant", "Positive", "Polite" });
            StartingDictionary.Add('Q', new string[] { "Quick", "Quizzical", "Quaint" });
            StartingDictionary.Add('R', new string[] { "Radiant", "Relaxed", "Reliable", "Rebellious", "Romantic", "Reckless" });
            StartingDictionary.Add('S', new string[] { "Serious", "Sexy", "Shy", "Smart", "Scholarly", "Sensible" });
            StartingDictionary.Add('T', new string[] { "Tenacious", "Tiresome", "Tolerant", "Tactful", "Talented", "Tough", "Thoughtful" });
            StartingDictionary.Add('U', new string[] { "Understanding", "Upbeat", "Useful" });
            StartingDictionary.Add('V', new string[] { "Virtuous", "Vile", "Vain" });
            StartingDictionary.Add('W', new string[] { "Warm", "Watchful", "Wacky", "Wise" });
            StartingDictionary.Add('X', new string[] { "Xenodochial" });
            StartingDictionary.Add('Y', new string[] { "Youthful", "Yawning" });
            StartingDictionary.Add('Z', new string[] { "Zany", "Zealous" });

            FinalDictionary = ConvertToHashSets(StartingDictionary);

        }

        internal virtual Dictionary<char,HashSet<string>> ConvertToHashSets(Dictionary<char,string[]> stringDict)
        {

            Dictionary<char, HashSet<string>> finalDict = new Dictionary<char, HashSet<string>>();
            foreach (var entry in stringDict)
            {
                HashSet<string> _newHash = new HashSet<string>();
                foreach (string _value in entry.Value)
                {
                    _newHash.Add(_value);
                }
                finalDict.Add(entry.Key, _newHash);
            }

            return finalDict;
        }
    }


    }