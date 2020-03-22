using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Exceptions {

    public class IncompatibleArgumentsException : Exception {
        public IncompatibleArgumentsException() : base() { }
        public IncompatibleArgumentsException(string message) : base(message) { }
        public IncompatibleArgumentsException(string message, Exception innerException) : base(message, innerException) { }
    }
}
