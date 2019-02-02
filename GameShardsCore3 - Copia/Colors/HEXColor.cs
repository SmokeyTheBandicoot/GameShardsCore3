using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GameShardsCore3.Attributes;
using GameShardsCore3.Mathematics.BaseConverter;
using GameShardsCore3.StringManipulation.Alphabet;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Colors {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0, 'b')]
    [WIP()]
    public struct HEXColor {

        [ToTest()]
        public byte Red { get; set; }

        [ToTest()]
        public byte Green { get; set; }

        [ToTest()]
        public byte Blue { get; set; }

        [ToTest()]
        public byte Alpha { get; set; }


        [ToTest()]
        /// <summary>
        /// HEXCode format. #RRGGBBAA or RRGGBBAA (Red, Green, Blue, Alpha)
        /// </summary>
        /// <param name="HexCode"></param>
        public HEXColor(string HexCode) {

            if (HexCode.StartsWith("#")) HexCode = HexCode.Replace("#", "");
            if (HexCode.Length != 8) throw new ArgumentException(LangManager.GetString("exception_bad_color_code", CurrentCulture));

            Red = (byte)BaseConverter.ConverToBase10(HexCode[0].ToString() + HexCode[1].ToString(), 16, Alphabet.Hexadecimal, false);
            Green = (byte)BaseConverter.ConverToBase10(HexCode[2].ToString() + HexCode[3].ToString(), 16, Alphabet.Hexadecimal, false);
            Blue = (byte)BaseConverter.ConverToBase10(HexCode[4].ToString() + HexCode[5].ToString(), 16, Alphabet.Hexadecimal, false);
            Alpha = (byte)BaseConverter.ConverToBase10(HexCode[6].ToString() + HexCode[7].ToString(), 16, Alphabet.Hexadecimal, false);
        }

        [ToTest()]
        /// <summary>
        /// HEXColor from System.Drawing.Color
        /// </summary>
        /// <param name="C"></param>
        public HEXColor(Color C) {
            Red = C.R;
            Green = C.G;
            Blue = C.B;
            Alpha = C.A;
        }

        /// <summary>
        /// HEXColor from ARGB strings
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="A"></param>
        [ToTest()]
        public HEXColor(string R, string G, string B, string A) {
            Red = (byte)BaseConverter.ConverToBase10(R, 16, Alphabet.Hexadecimal, false);
            Green = (byte)BaseConverter.ConverToBase10(G, 16, Alphabet.Hexadecimal, false);
            Blue = (byte)BaseConverter.ConverToBase10(B, 16, Alphabet.Hexadecimal, false);
            Alpha = (byte)BaseConverter.ConverToBase10(A, 16, Alphabet.Hexadecimal, false);
        }

        public HEXColor(byte R, byte G, byte B, byte A) {
            Red = R;
            Green = G;
            Blue = B;
            Alpha = A;
        }


        public static HEXColor FromARGB(byte R, byte G, byte B, byte A) {
            return new HEXColor(R, G, B, A);
        }

        public static HEXColor FromARGBColor(Color C) {
            return new HEXColor(C);
        }

        public static HEXColor FromCode(string Code) {
            return new HEXColor(Code);
        }

        public Color ToARGB() {
            return Color.FromArgb(Red, Green, Blue, Alpha);
        }

        [ToTest()]
        public override string ToString() {
            return String.Format("#{0}{1}{2}{3}",
                BaseConverter.ConvertToBaseN(Red, 16, Alphabet.Hexadecimal, 2),
                BaseConverter.ConvertToBaseN(Green, 16, Alphabet.Hexadecimal, 2),
                BaseConverter.ConvertToBaseN(Blue, 16, Alphabet.Hexadecimal, 2),
                BaseConverter.ConvertToBaseN(Alpha, 16, Alphabet.Hexadecimal, 2));
        }

    }

}
