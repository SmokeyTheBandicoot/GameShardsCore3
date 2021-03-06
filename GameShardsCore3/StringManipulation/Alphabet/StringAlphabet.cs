﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.StringManipulation.Alphabet {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmpokeyTheBandicoot")]
    public class StringAlphabet : Alphabet, IEnumerable<string> {

        public string[] strings;

        public StringAlphabet(string Name, string[] Chars) : base(Name, Chars) {
            this.Name = Name;
            this.Chars = Chars;
        }

        public override string ToString() {
            return base.ToString() + "; Chars: " + strings.ToString();
        }

        public new IEnumerator<string> GetEnumerator() {
            foreach (string c in strings) {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return strings.GetEnumerator();
        }



    }

}
