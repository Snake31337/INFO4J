using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Grimaldi.Leonardo._4J.ListaSemplice
{
    class Lista
    {
        const int NUMERO_OGGETTI = 1000;
        Caratteri[] c = new Caratteri[NUMERO_OGGETTI];

        public Lista()
        {
            const int NUMERO_GENERAZIONI = 30;
            for(int i = 0; i < NUMERO_GENERAZIONI; i++)     // genero 30 caratteri casuali
            {
                c[i] = new Caratteri();
                c[i].Index = i;
                c[i].Carattere = GeneraCarattere();

                if (i == NUMERO_GENERAZIONI - 1)    // all'ultimo elemento assegno indice = -1
                {
                    c[i].Index = -1;
                    break;
                }
            }
        }

        public void InserisciNodoInTesta(char carattere)
        {
            if (verificaDisponibilita())
            {
                int pos = getLastIndex();
                int old_index = c[0].Index;
                c[0].Index = pos;

                c[pos] = new Caratteri();
                c[pos].Carattere = carattere;
                c[pos].Index = old_index;
            }
        }

        private int getLastIndex()
        {
            int i = 0;
            for(i = 0; c[i] != null && i < NUMERO_OGGETTI; i++)
            {
            }

            return i;       // ritorna il numero di elementi, non l'indice dell'ultimo el.
        }

        private bool verificaDisponibilita()        // controllo se si possono aggiungere elementi all'array
        {
            bool flag = false;

            if (getLastIndex() < NUMERO_OGGETTI)
                flag = true;

            return flag;
        }

        public void SalvaSuFile(string nomeFile)
        {
            string json = JsonConvert.SerializeObject(c, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(nomeFile))
            {
                sw.Write(json);
            }
        }

        public void LeggiDaFile(string nomeFile)
        {
            string json;
            StreamReader sr = new StreamReader(nomeFile);
            json = sr.ReadToEnd();

            c = JsonConvert.DeserializeObject<Caratteri[]>(json);
        }

        private char GeneraCarattere()
        {
            Random rand = new Random();
            char carattere = (char)rand.Next('a', 'z');
            return carattere;
        }
    }
}
