using System;
using System.Collections.Generic;
using System.Text;

namespace Grimaldi.Leonardo._4J.ListaSemplice
{
    class Caratteri
    {
        char carattere;
        public char Carattere
        {
            get { return carattere; }
            set { carattere = value; }
        }


        int index; // posizione di questo oggetto
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        
        public Caratteri()
        {

        }

        public Caratteri(int i)
        {
            Random rand = new Random();
            carattere = (char)rand.Next('a', 'z');

            index = i;
        }

        public Caratteri(char input, int i)
        {
            carattere = input;

            index = i;
        }
    }
}
