using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.ResourceManager;
using GameShardsCore3.ResourceManager.LanguageManager;
using System.Globalization;
using System.Resources;
using System.Diagnostics;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.Core.LibLanguage {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [WIP()]
    public static class LibLanguageManager {


        public static CultureInfo CurrentCulture;
        public static System.Resources.ResourceManager LangManager = new System.Resources.ResourceManager("GameShardsCore3.Resources", typeof(LibLanguageManager).Assembly);

        public static readonly CultureInfo it_IT = new CultureInfo("it-IT");
        public static readonly CultureInfo en_US = new CultureInfo("en-US");
        public static readonly CultureInfo en_GB = new CultureInfo("en-GB");

        public static void InitLanguage(CultureInfo ci) {
            CurrentCulture = ci;
        }

    }

}
