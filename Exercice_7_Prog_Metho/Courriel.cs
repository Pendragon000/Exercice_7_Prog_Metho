using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7_Prog_Metho
{
    public class Courriel
    {
        private string _contenu;
        private DateTime _dateCreation;
        private bool _pieceJointe;
        public Courriel(string contenu,DateTime dateCreation,bool pieceJointe) 
        {
            _contenu = contenu;
            _dateCreation = dateCreation;
            _pieceJointe = pieceJointe;
        }
        public string getContenu()
        {
            return _contenu;
        }
        public DateTime getDateCreation()
        {
            return _dateCreation;
        }
        public bool isPieceJointe()
        {
            return _pieceJointe;
        }
    }
}
