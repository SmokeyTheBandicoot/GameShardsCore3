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
    public struct HSLColor {

        public int Hue { get; set; }
        public float Saturation { get; set; }
        public float Luminosity { get; set; }
        public byte Alpha { get; set; }

        [ToTest()]
        public HSLColor(int Hue, float Saturation, float Luminosity, byte Alpha) {
            if (!IsValidHue(Hue)) throw new ArgumentException(LangManager.GetString("exception_hue_invalid", CurrentCulture));
            if (!IsValidSL(Saturation)) throw new ArgumentException(LangManager.GetString("exception_saturation_invalid", CurrentCulture));
            if (!IsValidSL(Luminosity)) throw new ArgumentException(LangManager.GetString("exception_luminosity_invalid", CurrentCulture));
            this.Hue = Hue;
            this.Saturation = Saturation;
            this.Luminosity = Luminosity;
            this.Alpha = Alpha;
        }

        /// <summary>
        /// HSLColor from System.Drawing.Color. Calls HSLColor.FromARGBColor()
        /// </summary>
        /// <param name="C"></param>
        [ToTest()]
        public HSLColor(Color C) {
            HSLColor hsl = HSLColor.FromARGBColor(C);
            Hue = hsl.Hue;
            Saturation = hsl.Saturation;
            Luminosity = hsl.Luminosity;
            Alpha = hsl.Alpha;
        }

        /// <summary>
        /// Returns a System.Drawing.Color in which ARGB components are converted from HSL (alpha is the same)
        /// </summary>
        /// <returns></returns>
        [ToTest()]
        public Color ToARGB() {
            byte r, g, b;
            float C, X, m, r1 = 0, g1 = 0, b1 = 0;

            C = (1 - Abs(2 * Luminosity - 1) * Saturation);
            X = (C * (1 - Abs(Hue / 60) % 2 - 1));
            m = Luminosity - C / 2;

            switch (Hue) {
                case int n when n >= 0 && n < 60:
                    r1 = C;
                    g1 = X;
                    b1 = 0;
                    break;
                case int n when n >= 60 && n < 120:
                    r1 = X;
                    g1 = C;
                    b1 = 0;
                    break;
                case int n when n >= 120 && n < 180:
                    r1 = 0;
                    g1 = C;
                    b1 = X;
                    break;
                case int n when n >= 180 && n < 240:
                    r1 = 0;
                    g1 = X;
                    b1 = C;
                    break;
                case int n when n >= 240 && n < 300:
                    r1 = X;
                    g1 = 0;
                    b1 = C;
                    break;
                case int n when n >= 300 && n < 360:
                    r1 = C;
                    g1 = 0;
                    b1 = X;
                    break;
            }

            r = (byte)((r1 + m) * 255);
            g = (byte)((g1 + m) * 255);
            b = (byte)((b1 + m) * 255);
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
        public static HSLColor FromARGB(byte Red, byte Green, byte Blue, byte Alpha) {
            float r1, g1, b1;
            float cmax, cmin, delta;
            int h = 0;
            float s, l;
            r1 = (float)Red / 255;
            g1 = (float)Green / 255;
            b1 = (float)Blue / 255;

            cmax = Max(Max(r1, g1), b1);
            cmin = Min(Min(r1, g1), b1);
            delta = cmax - cmin;

            if (delta == 0)
                h = 0;
            else if (cmax == r1)
                h = (int)(60 * (((g1 - b1) / delta) % 6));
            else if (cmax == g1)
                h = (int)(60 * (((b1 - r1) / delta) + 2));
            else if (cmax == b1)
                h = (int)(60 * (((r1 - g1) / delta) + 4));

            l = (cmax + cmin) / 2;

            if (delta == 0) {
                s = 0;
            }
            else {
                s = (delta / 1 - Abs(2 * l - 1));
            }

            return new HSLColor(h, s, l, Alpha);
        }

        public static HSLColor FromARGBColor(Color C) {
            return FromARGB(C.R, C.G, C.B, C.A);
        }

        [ToTest()]
        public override string ToString() {
            return String.Format("H:{0} S:{1} L:{2} A:{3}",
               Hue, Saturation, Luminosity, Alpha);
        }

        private static bool IsValidHue(int Hue) {
            return Hue >= 0 && Hue <= 359;
        }

        private static bool IsValidSL(float Val) {
            return Val >= 0 && Val <= 1;
        }
    }

}
