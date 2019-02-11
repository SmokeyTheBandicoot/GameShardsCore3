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
    public class RYBColor {

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
