using System;

namespace Grimaldi.Leonardo._4J.GiocoDiCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Gioco di Carte di Leonardo Grimaldi");

            Carta c = new Carta(2, "C");
            Carta carta = new Carta(14, "P");

            if (c.Vince(carta))
            {
                Console.WriteLine("\nVince la prima carta");

            }
            else 
            {
                Console.WriteLine("\nVince la seconda carta");
            
            }

            Console.WriteLine("\n" + c.Visualizza());
        }
    }


    class Carta
    {
        int _valore;
        string _seme;

        public Carta(int valore, string seme)
        {
            if(ControllaValore(valore)) // Questo metodo controlla se il valore della carta e' compreso tra 2 e 14 (estremi compresi). Resituisce vero se il valore inserito e' giusto.
            {
                _valore = valore;
            } else
            {
                Console.WriteLine("Valore non inserito correttamente. Si sostituisce con il default di 2.");
                _valore = 2;
            }

            if(ControllaSeme(seme)) // Questo metodo controlla se il seme inserito e' tra C (cuori), Q (quadri), F (fiori), P (picche). Restituisce vero se il seme inserito e' giusto
            {
                _seme = seme;
            } else
            {
                Console.WriteLine("Seme non inserito correttamente. Si sostituisce con il default di Cuori.");
                _seme = "C";
            }       
        }

        public Carta()
        {
            Random rnd = new Random();
            _valore = rnd.Next(2, 14);
            _seme = ValoreInSeme(rnd.Next(1, 4));
        }

        public bool Vince(Carta c)
        {
            if(this._valore > c._valore)    // Confronto il valore di this._valore con il valore di un altro oggetto. Restituisce vero se e' piu grande il primo.
            {
                return true;
            } else if(this._valore == c._valore)
            {
                return ConfrontaSeme(c);        // Visto che i valori sono uguali, bisogna controllare se il seme e' maggiore. Restituisce vero se il primo e' maggiore.
            } else if (this._valore <= c._valore)
            {
                return false;   // Il secondo e' maggiore quindi restituisce falso.
            }

            return false;
        }

        private bool ConfrontaSeme(Carta c)
        {
            if(SemeInValore(this._seme) > SemeInValore(c._seme))    // Confronta il valore del seme della prima carta con quello della seconda
            {
                return true;
            } else
            {
                return false;
            }
        }

        private string ValoreInSeme(int valore)
        {
            string seme = "C";

            switch (valore)
            {
                case 1:
                    seme = "C";
                    break;
                case 2:
                    seme = "Q";
                    break;
                case 3:
                    seme = "F";
                    break;
                case 4:
                    seme = "P";
                    break;
                default:
                    seme = "C";
                    break;
            }

            return seme;
        }

        private int SemeInValore(string seme)   // Trasforma la stringa seme nel suo valore corrispondente
        {
            int valoreSeme = 1;
            switch (seme)
            {
                case "C":
                    valoreSeme = 1;
                    break;
                case "Q":
                    valoreSeme = 2;
                    break;
                case "F":
                    valoreSeme = 3;
                    break;
                case "P":
                    valoreSeme = 4;
                    break;
                default:
                    valoreSeme = 1;
                    break;
            }

            return valoreSeme;
        }

        private bool ControllaValore(int valore)    // Restituisce vero se il valore della carta e' accettabile
        {
            if (valore >= 2 && valore <= 14)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private bool ControllaSeme(string seme) // Restituisce vero se il valore del seme e' accettabile
        {
            if (seme == "C" || seme == "Q" || seme == "F" || seme == "P")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string Visualizza()  // Restituisce una stringa di output per visualizzare la carta
        {
            string nomeCarta;
            switch(_valore)     // Vengono formattati i numeri sopra il 10 assegnando il loro nome 
            {
                case 11:
                    nomeCarta = "Fante";
                    break;
                case 12:
                    nomeCarta = "Regina";
                    break;
                case 13:
                    nomeCarta = "Re";
                    break;
                case 14:
                    nomeCarta = "Asso";
                    break;
                default:
                    nomeCarta = _valore.ToString();
                    break;
            }

            string output = "Carta: " + nomeCarta + "\nSeme: " + _seme;


            return output;
        }
    }
}
