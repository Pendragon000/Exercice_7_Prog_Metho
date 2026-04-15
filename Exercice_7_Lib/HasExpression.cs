using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Lib
{
    public class HasExpression : ExpressionBase
    {
        public HasExpression()
        {
        }

        public override bool Evaluate(Courriel c)
        {
            return c.isPieceJointe();
        }
    }
}
