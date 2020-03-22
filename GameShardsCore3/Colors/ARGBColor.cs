using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.Colors {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    public class ARGBColor : Color {

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public ARGBColor(byte red, byte green, byte blue, byte alpha) {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public override Color FromARGB(ARGBColor color) {
            return color.ToARGB();
        }

        public override ARGBColor ToARGB() {
            return this;
        }


    }
}
