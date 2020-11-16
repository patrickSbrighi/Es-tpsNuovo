using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsTPS
{
    public class ClasseBrano
    {
        private string _autore;
        private int _durata;
        private string _nome;
        public ClasseBrano(string nome, string autore, int  durata)
        {
            if (string.IsNullOrEmpty(nome) == false && string.IsNullOrEmpty(autore) == false)
            {
                _autore = autore;
                _durata = durata;
                _nome = nome;
            }
            else
            {
                throw new Exception("dati non validi");
            }

        }

        // Durata in secondi
        public int  Durata
        {
            get
            {
                return _durata;
            }
            set
            {
                if ( value > 30)
                {
                    throw new Exception("durata non valida");


                }

                else
                {
                    _durata = value;
                }
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("nome non valido");
                }
                else
                {
                    _nome = value;
                }

            }
        }

        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("autore non valido");
                }
                else
                {
                    _autore = value;
                }
            }
        }
        public override string ToString()
        {
            return Nome + "," + Autore + "," + Durata;
        }
    }
}