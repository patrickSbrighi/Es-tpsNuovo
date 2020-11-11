using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsTPS
{
    public class Brano
    {
        private string _titolo;
        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Titolo non valido");
                }
                else
                {
                    _titolo = value;
                }
            }
        }

        private string _autore;
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Autore non valido");
                }
                else
                {
                    _autore = value;
                }
            }
        }

        private int _durata; // la durata è in secondi
        public int Durata
        {
            get
            {
                return _durata;
            }
            set
            {
                if (value < 30)
                {
                    throw new Exception("Durata non valida");
                }
                else
                {
                    _durata = value;
                }
            }
        }

        public Brano(string titolo, string autore, int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        public override string ToString()
        {
            return Titolo + ", " + Autore + ", " + Durata;
        }

        public bool ShortSong(int durata)
        {
            if (Durata < durata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
