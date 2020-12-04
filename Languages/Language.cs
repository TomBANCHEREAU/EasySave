using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave.Languages
{
    public class Language
    {
        private static Dictionary<String,String> lang;

        private static Dictionary<String, String> Lang
        {
            get {
                if (lang == null)
                    throw new NullReferenceException("");
                return lang;
            }
        }

        public static void LoadLanguage(String language)
        {
            if (!File.Exists(@"Languages\"+language+"-lang.json"))
                throw new Exception("");
            lang = JsonConvert.DeserializeObject<Dictionary<String, String>>(File.ReadAllText(@"Languages\" + language + "-lang.json"));
        }
        public static String GetText(String key)
        {
            return Lang[key];
        }
    }
}
