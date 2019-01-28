using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.StringManipulation.Alphabet {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmpokeyTheBandicoot")]
    public class CharAlphabet : Alphabet, IEnumerable<char>{

        public char[] Chars { get; set; }

        public override string ToString() {
            return base.ToString() + "; Chars: " + Chars.ToString();
        }

        public IEnumerator<char> GetEnumerator() {
            foreach (char c in Chars) {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return Chars.GetEnumerator();
        }

        public CharAlphabet(char[] chars) {
            Chars = chars;
        }

        public CharAlphabet() {
            Chars = null;
        }
    }

}
