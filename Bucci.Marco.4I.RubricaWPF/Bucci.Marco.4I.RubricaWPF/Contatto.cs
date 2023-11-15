using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucci.Marco._4I.RubricaWPF
{
    class Contatto
    {
        //Attributi
        private string _nome;
        private string _cognome;
        private string _email;
        private int _numero;
        private string _cellulare;

        //Costruttori

        //Costruzione di un contatto tramite il file CSV
        public Contatto(string row)
        {
            string[] fields = row.Split(';');

            if (fields.Length >= 5)
            {
                _numero = 0;
                int.TryParse(fields[0], out _numero);

                _nome = fields[1];
                _cognome = fields[2];
                _cellulare = fields[3];
                _email = fields[4];
            }
        }
        //Costruzione di un contatto vuoto
        public Contatto() { }


        //Properties
        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Cellulare { get => _cellulare; set => _cellulare = value; }
        public int Numero { get => _numero; set => _numero = value; }
    }
}
