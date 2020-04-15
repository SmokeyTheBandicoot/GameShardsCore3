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

        public new char[] Chars { get; set; }

        public new string Name { get; set; }

        public override string ToString() {
            return base.ToString() + "; Chars: " + Chars.ToString();
        }

        public new IEnumerator<char> GetEnumerator() {
            foreach (char c in Chars) {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return Chars.GetEnumerator();
        }

        public CharAlphabet(string Name, char[] chars) : base(Name, null) {
            base.Name = Name;
            this.Chars = chars;
        }
    }

}
