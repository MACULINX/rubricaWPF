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
        private static int _numero;
        private int _lastNumber;
        private string _cellulare;

        //Costruttori

        //Costruzione di un contatto tramite + parametri
        public Contatto(string nome, string congnome, string cellulare, string email)
        {
            Nome = nome;
            Cognome = congnome;
            Cellulare = cellulare;
            Email = email;
            this._lastNumber = Numero++;
        }
        //Costruzione di un contatto tramite il file CSV
        public Contatto(string row)
        {
            string[] fields = row.Split(';');
            if (fields.Length >= 4)
            {
                _nome = fields[0];
                _cognome = fields[1];
                _cellulare = fields[2];
                _email = fields[3];
            }
            this._lastNumber = Numero++;


        }
        //Costruzione di un contatto vuoto
        public Contatto() {
            this._lastNumber = Numero++;
        }


        //Properties
        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Cellulare { get => _cellulare; set => _cellulare = value; }
        private int Numero { get => _numero; set => _numero = value; }
        public int LastNumber { get => _lastNumber; set => _lastNumber = value; }
    }
}
