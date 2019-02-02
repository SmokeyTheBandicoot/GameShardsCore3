using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.StringManipulation.Alphabet;
using GameShardsCore3.StringManipulation;
using GameShardsCore3.Attributes;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Mathematics.BaseConverter {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    public static class BaseConverter {

        [Tested()]
        public static ulong ConverToBase10(string Number, int StartBase, CharAlphabet alphabet = null, bool CaseSensitive = false) {

            //If it is case sensitive, then just use the upper case version
            if (!CaseSensitive) Number = Number.ToUpper();

            //Default to HEX alphabet
            if (alphabet == null) alphabet = CharAlphabet.Hexadecimal;

            //Gets the chars of the number into a list form
            List<char> chars = Number.ToCharArray().ToList();

            int[] nums = new int[chars.Count - 1];

            //All nums should be -1
            for (int z = 0; z < nums.Count(); z++)
                nums[z] = -1;

            //Iterates through alphabet chars and when it finds the char
            //then it takes it's index, which is also it's value
            for (int x = 0; x < chars.Count(); x++)
                for (int y = 0; y < alphabet.Count(); y++)
                    nums[x] = y;

            //Conversion has failed, there's still a number which is -1
            for (int k = 0; k < chars.Count(); k++)
                if (nums[k] == -1)
                    throw new ArgumentException(LangManager.GetString("exception_conversion_failed", CurrentCulture));

            ulong result = 0;

            //takes all found indexes and translates them to base ten
            for (int y = nums.Count() - 1; y >= 0; y--)
                result += (ulong) (nums[(nums.Count() - 1) - y] * (StartBase ^ y));

            return result;
        }

        [Tested()]
        [Version(1,0,0,'a')]
        public static string ConvertToBaseN(ulong Number, int TargetBase, CharAlphabet alphabet = null, int MinDigits = 1, int sign = 0) {

            //Exceptions
            if (alphabet.Chars.Count() < TargetBase) {
                throw new ArgumentException(LangManager.GetString("exception_alphabet_too_short", CurrentCulture));
            }

            if (Number < 0) {
                sign = -1;
            }

            //Defaults
            if (alphabet == null) {
                alphabet = Alphabet.Hexadecimal;
            }

            //Init
            string result = "";
            ulong placeholder = Number;

            //Conversion
            if (Number == 0) {
                sign = 0;
                result = result.Insert(0, alphabet.Chars[0].ToString());
            }
            else {
                while (placeholder != 0) {
                    result += alphabet.Chars[(int)placeholder % TargetBase];
                    placeholder -= placeholder % (ulong) TargetBase;
                    placeholder /= (ulong) TargetBase;
                }
            }

            //Add mindigits
            if (result.Length < MinDigits) {
                for (int x = result.Length; x < MinDigits; x++) {
                    result = result.Insert(0, alphabet.Chars[0].ToString());
                }
            }

            return StringManipulator.Reverse(result);

        }
    }

}
