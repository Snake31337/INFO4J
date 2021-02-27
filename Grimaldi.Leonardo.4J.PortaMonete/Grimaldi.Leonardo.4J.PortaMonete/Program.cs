using System;

namespace Grimaldi.Leonardo._4J.PortaMonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Portamonete di Leonardo Grimaldi");

            PortaMonete pm = new PortaMonete(3, 5, 7); // cinquantaCentesimi, unEuro, dueEuro

            pm.InserisciMoneta(0.5, 25);

            Console.WriteLine("\n" + pm.Denaro());

            Console.WriteLine("\n" + pm.DenaroDollari());

            Console.WriteLine("\n" + pm.DenaroPerTipo());

        }
    }


    class PortaMonete
    {
        int _cinquantaCent;
        int _unEuro;
        int _dueEuro;

        public PortaMonete()
        {
            _cinquantaCent = 0;
            _unEuro = 0;
            _dueEuro = 0;
        }

        public PortaMonete(int cinquantaCent, int unEuro, int dueEuro)
        {
            _cinquantaCent = cinquantaCent;
            _unEuro = unEuro;
            _dueEuro = dueEuro;
        }

        public void InserisciMoneta(double valore)
        {
            switch(valore)
            {
                case 0.5:
                    _cinquantaCent++;
                    break;
                case 1:
                    _unEuro++;
                    break;
                case 2:
                    _dueEuro++;
                    break;
                default:
                    Console.WriteLine("Errore. Moneta non riconosciuta");
                    break;
            }
        }

        public void InserisciMoneta(double valore, int n)
        {
            switch (valore)
            {
                case 0.5:
                    _cinquantaCent += n;
                    break;
                case 1:
                    _unEuro += n;
                    break;
                case 2:
                    _dueEuro += n;
                    break;
                default:
                    Console.WriteLine("Errore. Moneta non riconosciuta");
                    break;
            }
        }

        public string Denaro()
        {
            double totale = _unEuro + _dueEuro * 2 + _cinquantaCent * 0.50;
            
            string output = "Il totale del vostro portamonete è " + totale + " euro";

            return output;
        }

        public string DenaroDollari()
        {
            double totale = (_unEuro + _dueEuro * 2 + _cinquantaCent * 0.50) * 1.21998;
            totale = Math.Round(totale, 4);

            string output = "Il totale del vostro portamonete è " + totale + " dollari";

            return output;
        }

        public string DenaroPerTipo()
        {
            string output = "Nel suo portamonete ha:\n" + _dueEuro + " monete da due euro\n" + _unEuro + " monete da un euro\n" + _cinquantaCent + " monete da cinquanta centesimi";

            return output;
        }
    }
}
