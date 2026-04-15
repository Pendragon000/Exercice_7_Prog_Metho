using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Lib
{
    public class BeforeDateExpression : ExpressionBase
    {

        private readonly DateTime _date;

        public BeforeDateExpression(DateTime value)
        {
            _date = value;
        }

        public override bool Evaluate(Courriel c)
        {
            return c.getDateCreation() < _date;
        }
    }
}
