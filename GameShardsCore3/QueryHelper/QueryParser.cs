using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.StringManipulation.Alphabet;

namespace GameShardsCore3.QueryHelper {
    
    public class QueryParser {

        private string expression;
        private Stack<IQueryExpressionOperator> parsed;
        private IRegistry registry;
        private Alphabet alhpabet;

        public QueryParser(IRegistry registry, string expression) {
            this.expression = expression;
            this.registry = registry;
            parsed = new Stack<IQueryExpressionOperator>();
        }



        public IRegistry parse(string expression) {
            // First the operators that join the expression (logic)

            // Then the operators that split the expression (unknowns and groups)

            throw new NotImplementedException();
        }

        public INumberSequence parseNumberSequence(string expression) {
            throw new NotImplementedException();
        }

         

    }

}
