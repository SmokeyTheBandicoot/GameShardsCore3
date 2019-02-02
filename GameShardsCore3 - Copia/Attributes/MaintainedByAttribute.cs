﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Attributes {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class MaintainedByAttribute : Attribute {

        private string ProjectMember { get; set; }

        public MaintainedByAttribute(string member) {
            this.ProjectMember = member;
        }
    }
}
