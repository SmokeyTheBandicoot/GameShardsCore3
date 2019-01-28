using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.ResourceManager {


    /// <summary>
    /// Main entry class. Override this class and implement your own 
    /// functions
    /// </summary>
    [Serializable()] public abstract class ResourceEntry<T> {

        public Dictionary<string, T> REntry { get; set; }
       
        public void FromFile(string Path, string EntryFormatting) {

        }

    }

}
