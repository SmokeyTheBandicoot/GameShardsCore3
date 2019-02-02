using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Attributes {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class VersionAttribute : Attribute{

        public int Major { get; set; }
        public int Minor { get; set; }
        public int Revision { get; set; }
        public char Build { get; set; }

        public VersionAttribute(int major, int minor, int revision, char build = 'a') {
            Major = major;
            Minor = minor;
            Revision = revision;
            Build = build;
        }
    }
}
