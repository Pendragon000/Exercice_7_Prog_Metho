using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Lib
{
    public class ContenuExpression : ExpressionBase
    {
        private readonly string _contenu; 
        public ContenuExpression(string contenu)
        {
            _contenu = contenu;
        }

        public override bool Evaluate(Courriel c)
        {
            return c.getContenu() == _contenu;
        }
    }
}
