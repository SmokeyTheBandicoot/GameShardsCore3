using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameShardsCore3.Gameworks.Cards {

    public interface ISeed {
        string name { get; }
        char symbol { get; }
        Color color { get; }
    }

}
