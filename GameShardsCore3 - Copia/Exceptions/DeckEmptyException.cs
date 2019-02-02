using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Exceptions {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    public class DeckEmptyException : Exception{
        public DeckEmptyException(string message) : base(message) { }
    }

}
