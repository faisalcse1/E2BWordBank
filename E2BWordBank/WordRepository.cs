using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace E2BWordBank
{
    public static class WordRepository
    {
        /// <summary>
        /// Retrieves all words from the dictionary or word database.
        /// </summary>
        /// <returns>A list of all words available in the dictionary.</returns>
        public static List<Word> GetAllWords()
        {
            string wordFileName = "/E2BCData.json";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string wordFilePath=baseDirectory + wordFileName;
            string jsonWords=File.ReadAllText(wordFilePath);
            return JsonConvert.DeserializeObject<List<Word>>(jsonWords);
        }

        /// <summary>
        /// Retrieves a list of words that start with the specified prefix and match the given type.
        /// </summary>
        /// <param name="prefix">The starting substring or letters to filter words by.</param>
        /// <param name="type">The type or category of words to retrieve (e.g., En, Bn).</param>
        /// <returns>A list of words that match the specified prefix and type.</returns>
        public static List<Word> GetWordsStartingWith(string prefix, WordType type= WordType.En)
        {
            var words = GetAllWords();
            return words.Where(c=>
            (type== WordType.En && c.En.ToLower().Contains(prefix.ToLower()))
            || (type == WordType.Bn && c.Bn.Contains(prefix))
            ).ToList();
        }

        /// <summary>
        /// Searches for a single word that exactly matches the specified prefix and type.
        /// </summary>
        /// <param name="prefix">The exact word or substring to match.</param>
        /// <param name="type">The type or category of the word to retrieve (e.g., En, Bn). Defaults to English (WordType.En).</param>
        /// <returns>A single word that exactly matches the given prefix and type, or null if no match is found.</returns>
        public static Word FindWord(string prefix, WordType type = WordType.En)
        {
            var words = GetAllWords();
            return words.FirstOrDefault(c =>
            (type == WordType.En && c.En.ToLower()==prefix.ToLower())
            ||(type == WordType.Bn && c.Bn==prefix)
            );
        }

    }
}
