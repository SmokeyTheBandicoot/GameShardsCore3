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
    public class RYBColor : Color {

        public byte Red { get; set; }
        public byte Yellow { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public RYBColor(byte red, byte yellow, byte blue, byte alpha) {
            Red = red;
            Yellow = yellow;
            Blue = blue;
            Alpha = alpha;
        }

        [ToTest()]
        public static RYBColor FromARGBColor(byte Red, byte Green, byte Blue, byte Alpha) {
            // Remove the whiteness from the color
            float[] arr = { Red, Green, Blue };
            float w = arr.Min();
            float r = Red - w;
            float g = (float)Green - w;
            float b = (float)Blue - w;

            float[] arr2 = { r, g, b};
            float mg = arr2.Max();

            float[] arr3 = { r, g};
            float y = arr3.Min();
            r -= y;
            g -= y;

            if (b == 1 && g == 1) {
                b /= 2.0F;
                g /= 2.0F;
            }

            y += g;
            b += g;

            float[] arr4 = { r, y, b };
            float my = arr4.Max();
            
            if (my == 1) {
                float n = mg / my;
                r *= n;
                y *= n;
                b *= n;
            }

            r += w;
            y += w;
            b += w;

            return new RYBColor((byte)Math.Round(r, 0), (byte)Math.Round(y, 0), (byte)Math.Round(b, 0), Alpha);

        }

        public ARGBColor ToARGBColor() {

            float[] arr = { Red, Yellow, Blue };
            float w = arr.Min();
            float r = Red - w;
            float y = Yellow - w;
            float b = Blue - w;

            float[] arr2 = {r, y, b};
            float my = arr2.Max();

            // Get the green out of the yellow and blue
            float g = Math.Min(y, b);
            y -= g;
            b -= g;

            if (b == 1 && g == 1) {
                b *= 2.0F;
                g *= 2.0F;
            }

            r += y;
            g += y;

            float[] arr3 = { r, g, b };
            float mg = arr3.Max();

            if (mg == 1) {
                float n = my / mg;
                r *= n;
                g *= n;
                b *= n;
            }

            r += w;
            g += w;
            b += w;

            return new ARGBColor((byte)Math.Round(r, 0), (byte)Math.Round(g, 0), (byte)Math.Round(b, 0), Alpha);
        }

        public override Color FromARGB(ARGBColor color) {
            return FromARGBColor(color.Red, color.Green, color.Blue, color.Alpha);
        }

        public override ARGBColor ToARGB() {
            return ToARGBColor();
        }

    }


    /*
     * local ryb2rgb = function( R, Y, B ) 
  local R, Y, B = R*R*(3-R-R), Y*Y*(3-Y-Y), B*B*(3-B-B)
  return 1.0 + B * ( R * (0.337 + Y * -0.137) + (-0.837 + Y * -0.163) ),
    1.0 + B * ( -0.627 + Y * 0.287) + R * (-1.0 + Y * (0.5 + B * -0.693) - B * (-0.627) ),
    1.0 + B * (-0.4 + Y * 0.6) - Y + R * ( -1.0 + B * (0.9 + Y * -1.1) + Y )
end
     */
}
