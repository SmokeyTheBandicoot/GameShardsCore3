using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Attributes {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class WIPAttribute : Attribute {
    }

}
