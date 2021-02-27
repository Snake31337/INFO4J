using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Grimaldi.Leonardo._4J.Contagi
{
    class Lista
    {
        List<Giorno> listaGiorni = new List<Giorno>();

        public Lista()
        {

        }

        public void JsonToList(string filePath)
        {
            string file;
            using (var reader = new StreamReader(filePath))
            {
                file = reader.ReadToEnd();
            }
            listaGiorni = JsonConvert.DeserializeObject<List<Giorno>>(file);
        }

        public void ListToJson(string filePath)
        {
            String jsonToWrite = JsonConvert.SerializeObject(listaGiorni, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(jsonToWrite);
            }
        }

        public void MostraLista()
        {
            foreach(Giorno g in listaGiorni)
            {
                Console.WriteLine("Data: " + g.Data);
                Console.WriteLine("Progressivo: " + g.Progressivo);
                Console.WriteLine("Contagi: " + g.Contagi);
            }
        }

        public void DateRange(string data1, string data2)
        {
            bool flag = false;
            foreach (Giorno g in listaGiorni)
            {
                if (g.Data == data1)
                {
                    flag = true;
                }
                if (flag)
                {
                    Console.WriteLine("Data: " + g.Data);
                    Console.WriteLine("Contagi : " + g.Contagi);
                    if (g.Data == data2)
                        break;
                }
            }
        }
    }
}
