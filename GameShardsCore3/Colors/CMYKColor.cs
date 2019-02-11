using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GameShardsCore3.Attributes;
using static System.Math;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Colors {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    public class CMYKColor : Color {

        public float Cyan { get; set; }
        public float Magenta { get; set; }
        public float Yellow { get; set; }
        public float Black { get; set; }
        public byte Alpha { get; set; }

        [ToTest()]
        public CMYKColor(float Cyan, float Magenta, float Yellow, float Black, byte Alpha) {
            if (!IsValidPercent(Cyan)) throw new ArgumentException(LangManager.GetString("exception_invalid_percent", CurrentCulture));
            if (!IsValidPercent(Magenta)) throw new ArgumentException(LangManager.GetString("exception_invalid_percent", CurrentCulture));
            if (!IsValidPercent(Yellow)) throw new ArgumentException(LangManager.GetString("exception_invalid_percent", CurrentCulture));
            if (!IsValidPercent(Black)) throw new ArgumentException(LangManager.GetString("exception_invalid_percent", CurrentCulture));
            this.Cyan = Cyan;
            this.Magenta = Magenta;
            this.Yellow = Yellow;
            this.Black = Black;
            this.Alpha = Alpha;
        }

        /// <summary>
        /// CMYKColor from System.Drawing.Color. Calls CMYKColor.FromARGBColor()
        /// </summary>
        /// <param name="C"></param>
        [ToTest()]
        public CMYKColor(Color C) {
            CMYKColor cmyk = CMYKColor.FromARGBColor(C);
            Cyan = cmyk.Cyan;
            Magenta = cmyk.Magenta;
            Yellow = cmyk.Yellow;
            Black = cmyk.Black;
            Alpha = cmyk.Alpha;
        }

        /// <summary>
        /// Returns a System.Drawing.Color in which ARGB components are converted from HSL (alpha is the same)
        /// </summary>
        /// <returns></returns>
        [ToTest()]
        public Color ToARGB() {
            byte r, g, b;
            r = (byte)(255 * (1 - Cyan) * (1 - Black));
            g = (byte)(255 * (1 - Magenta) * (1 - Black));
            b = (byte)(255 * (1 - Yellow) * (1 - Black));
            return Color.FromArgb(Alpha, r, g, b);
        }

        /// <summary>
        /// Converts a ARGB color code to HSL Color.
        /// </summary>
        /// <param name="Red"></param>
        /// <param name="Green"></param>
        /// <param name="Blue"></param>
        /// <param name="Alpha"></param>
        /// <returns></returns>
        [ToTest()]
        public static CMYKColor FromARGB(byte Red, byte Green, byte Blue, byte Alpha) {
            float r1, b1, g1;
            float c, m, y, k;

            r1 = (float)Red / 255;
            g1 = (float)Green / 255;
            b1 = (float)Blue / 255;

            k = 1 - Max(Max(r1, g1), b1);

            c = (1 - r1 - k) / (1 - k);
            m = (1 - g1 - k) / (1 - k);
            y = (1 - b1 - k) / (1 - k);

            return new CMYKColor(c, m, y, k, Alpha);
        }

        public static CMYKColor FromARGBColor(Color C) {
            return FromARGB(C.R, C.G, C.B, C.A);
        }

        [ToTest()]
        public override string ToString() {
            return String.Format("C:{0} M:{1} Y:{2} K:{3} A:{4}",
               Cyan, Magenta, Yellow, Black, Alpha);
        }

        private static bool IsValidPercent(float Val) {
            return Val >= 0 && Val <= 1;
        }
    }

}

