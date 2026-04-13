using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Prog_Metho
{
    public class AfterDateExpression : ExpressionBase
    {
        private readonly DateTime _date;

        public AfterDateExpression(DateTime value)
        {
            _date = value;
        }

        public override bool Evaluate(Courriel c)
        {
            return c.getDateCreation() > _date;
        }
    }
}
