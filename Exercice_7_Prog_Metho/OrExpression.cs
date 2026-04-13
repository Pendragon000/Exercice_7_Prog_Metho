using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Prog_Metho
{
    public class OrExpression : ExpressionBase
    {
        private readonly ExpressionBase expression1;
        private readonly ExpressionBase expression2;
        public OrExpression(ExpressionBase expression1, ExpressionBase expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public override bool Evaluate(Courriel c)
        {
            return expression1.Evaluate(c) || expression2.Evaluate(c);
        }
    }
}
