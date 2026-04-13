using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Prog_Metho
{
    public class Filtre
    {
        private ExpressionBase _filtre;
        public Filtre(string filtre) 
        {
            string prefixeFiltre = InfixeToPrefixe(filtre);
            List<string> tokens = prefixeFiltre.Split(" ").ToList();
            _filtre = ParseToken(tokens);
        }
        public bool Filtrer(Courriel courriel)
        {
            return _filtre.Evaluate(courriel);
        }
        private ExpressionBase ParseToken(List<string> tokens)
        {
            ArgumentNullException.ThrowIfNull(tokens);
            string currToken = tokens[0];
            tokens.RemoveAt(0);
            if (currToken.Contains("has:"))
            {
                return new HasExpression();
            }
            else if (currToken.Contains("before:"))
            {
                return new BeforeDateExpression(DateTime.Parse(currToken.Split(":")[1]));
            }
            else if (currToken.Contains("after:"))
            {
                return new AfterDateExpression(DateTime.Parse(currToken.Split(":")[1]));
            }
            else if (currToken.Contains("AND"))
            {
                return new AndExpression(ParseToken(tokens), ParseToken(tokens));
            }
            else if (currToken.Contains("OR"))
            {
                return new OrExpression(ParseToken(tokens), ParseToken(tokens));
            }
            else
            {
                return new ContenuExpression(currToken);
            }
        }

        private static string InfixeToPrefixe(string infixeString)
        {
            List<string> tokens = infixeString.Split(" ").ToList();
            Stack<string> prefixTokens = new();
            for (int i = tokens.Count - 1; i >= 0; i--)
            {
                if (tokens.Count == 1)
                {
                    prefixTokens.Push(tokens[i]);
                    break;
                }
                string currToken = tokens[i].Trim();
                string op = tokens[i - 1].Trim();
                string seconToken = tokens[i - 2].Trim();
                tokens.RemoveAt(i - 1);
                if (currToken == "AND" && i - 2 != 0)
                {
                    string temp = currToken;
                    currToken = seconToken;
                    seconToken = temp;
                }
                prefixTokens.Push(currToken);
                prefixTokens.Push(seconToken);
                tokens[i - 2] = op;

                if (i - 2 == 0)
                {
                    prefixTokens.Push(op);
                    break;
                }
                i--;
            }
            string output = "";
            foreach (string token in prefixTokens)
            {
                output += token + " ";
            }
            return output.Trim();
        }
    }
}
