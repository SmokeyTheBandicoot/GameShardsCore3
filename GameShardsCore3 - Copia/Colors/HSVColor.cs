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
    public struct HSVColor {

        public int Hue { get; set; }
        public float Saturation { get; set; }
        public float Value { get; set; }
        public byte Alpha { get; set; }

        [ToTest()]
        public HSVColor(int Hue, float Saturation, float Value, byte Alpha) {
            if (!IsValidHue(Hue)) throw new ArgumentException(LangManager.GetString("exception_hue_invalid", CurrentCulture));
            if (!IsValidSV(Saturation)) throw new ArgumentException(LangManager.GetString("exception_saturation_invalid", CurrentCulture));
            if (!IsValidSV(Value)) throw new ArgumentException(LangManager.GetString("exception_value_invalid", CurrentCulture));
            this.Hue = Hue;
            this.Saturation = Saturation;
            this.Value = Value;
            this.Alpha = Alpha;
        }

        /// <summary>
        /// HSVColor from System.Drawing.Color. Calls HSVColor.FromARGBColor()
        /// </summary>
        /// <param name="C"></param>
        [ToTest()]
        public HSVColor(Color C) {
            HSVColor hsv = HSVColor.FromARGBColor(C);
            Hue = hsv.Hue;
            Saturation = hsv.Saturation;
            Value = hsv.Value;
            Alpha = hsv.Alpha;
        }

        /// <summary>
        /// Returns a System.Drawing.Color in which ARGB components are converted from HSV (alpha is the same)
        /// </summary>
        /// <returns></returns>
        [ToTest()]
        public Color ToARGB() {
            byte r, g, b;
            float C, X, m, r1 = 0, g1 = 0, b1 = 0;

            C = Value * Saturation;
            X = (C * (1 - Abs(Hue / 60) % 2 - 1));
            m = Value - C;

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
        /// Converts a ARGB color code to HSV Color.
        /// </summary>
        /// <param name="Red"></param>
        /// <param name="Green"></param>
        /// <param name="Blue"></param>
        /// <param name="Alpha"></param>
        /// <returns></returns>
        [ToTest()]
        public static HSVColor FromARGB(byte Red, byte Green, byte Blue, byte Alpha) {
            float r1, g1, b1;
            float cmax, cmin, delta;
            int h = 0;
            float s, v;
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

            v = cmax;

            if (delta == 0) {
                s = 0;
            }
            else {
                s = delta / cmax;
            }

            return new HSVColor(h, s, v, Alpha);
        }

        public static HSVColor FromARGBColor(Color C) {
            return FromARGB(C.R, C.G, C.B, C.A);
        }

        [ToTest()]
        public override string ToString() {
            return String.Format("H:{0} S:{1} V:{2} A:{3}",
               Hue, Saturation, Value, Alpha);
        }

        private static bool IsValidHue(int Hue) {
            return Hue >= 0 && Hue <= 359;
        }

        private static bool IsValidSV(float Val) {
            return Val >= 0 && Val <= 1;
        }
    }

}
