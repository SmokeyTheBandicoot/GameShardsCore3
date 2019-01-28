using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.StringManipulation {

    public static class StringManipulator {

        /// <summary>
        /// Returns if the string is palindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string str) {
            for (int i = 0; i < (str.Length + str.Length % 2) / 2; i++) {
                if (str[i] != str[str.Length - i]) return false;
            } return true;
        }

        /// <summary>
        /// Reverses a string returning another string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str) {
            string res = "";
            for (int x = str.Length - 1; x >= 0; x--) {
                res += str[x];
            }
            return res;
        }

    }

}
