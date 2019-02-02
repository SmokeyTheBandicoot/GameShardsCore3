using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameShardsCore3.ResourceManager.LanguageManager {

    public class LanguageManager {

        public ResourceRegistry<string> LanguageRegistry;

        /// <summary>
        /// Loads a Registry from file. Uses a delimiter string for both keys and entries. For example:
        /// LanguageRegistry.FromFile(path, "=", "§", ";");
        /// </summary>
        /// 
        /// <example>
        /// Called on this text file:
        /// 
        /// #Language Registry File:
        /// §ItalianIT:
        /// color_red = Colore rosso;
        /// color_blue = Colore blu;
        /// generic_exception = Qualcosa è andato storto;
        /// message_with_newline = Messaggio con...
        /// ...testo a capo;
        /// §EnglishUS:
        /// color_red = Red color;
        /// color_blue = Blue color;
        /// generic_exception = Something went wrong;
        /// message_with_newline = Message with...
        /// ...newline;
        /// </example>
        /// 
        /// <param name="path"></param>
        /// <param name="ExpressionSeparator">The string/chars which separate the key from its values</param>
        /// <param name="KeySeparator">Character which indicates that</param>
        /// <param name="EntryTerminator">string which indicate that the entry is terminated</param>
        /// <param name="Comment">Comment character(s)</param>
        //public void FromFile(string path, string ExpressionSeparator, string KeySeparator, string EntryTerminator, string Comment = "#") {

        //    if (KeySeparator == null || KeySeparator.Equals(String.Empty) {
        //        throw new ArgumentNullException("");
        //    }
        //    string content;
        //    try {
        //        content = File.ReadAllText(path);
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine(ex.ToString());
        //        return;
        //    }
        //}

        public string GetLang(string key, string lang) {
            return LanguageRegistry.Registry[lang].REntry[key];
        }

    }

}
