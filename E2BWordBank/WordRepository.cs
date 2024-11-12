using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace E2BWordBank
{
    public static class WordRepository
    {
        
        public static List<Word> GetAll()
        {
            string wordFileName = "/E2BCData.json";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string wordFilePath=baseDirectory + wordFileName;
            string jsonWords=File.ReadAllText(wordFilePath);
            return JsonConvert.DeserializeObject<List<Word>>(jsonWords);
        }

        public static List<Word> GetWordsStartingWith(string prefix, string type)
        {
            var words = GetAll();
            return words.Where(c=>
            (type=="en"&& c.En.ToLower().Contains(prefix.ToLower()))
            || (type == "bn" && c.Bn.Contains(prefix))
            ).ToList();
        }

        
    }
}
