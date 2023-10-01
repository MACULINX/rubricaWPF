using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.RubricaWPF
{
    class Contatto
    {
        private string _nome;
        private string _cognome;
        private int _numero;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public int Numero { get => _numero; set => _numero = value; }

    }
}
