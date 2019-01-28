using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Attributes {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class DevelopedByAttribute : Attribute {

        private string ProjectMember { get; set; }

        public DevelopedByAttribute(string member) {
            this.ProjectMember = member;
        }
    }
}
