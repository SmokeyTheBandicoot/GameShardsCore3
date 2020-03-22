using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GameShardsCore3.Attributes;

namespace GameShardsCore3.Colors {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    public abstract class Color {

        public abstract ARGBColor ToARGB();
        public abstract Color FromARGB(ARGBColor color);

    }
}
