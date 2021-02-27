using System;

namespace Grimaldi.Leonardo._4J.Contagi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Contagi di Leonardo Grimaldi");


            Lista l = new Lista();

            Console.WriteLine("\nPremendo invio verrà letto il file JSON, convertito in Lista di oggetti Giorno e la lista verrà stampata e riconvertita in JSON con le date formattate");
            Console.ReadLine();
            l.JsonToList("ContagiRimini.json");     // devi mettere il tipo del file (es. ".json")
            l.MostraLista();
            l.ListToJson("lista.json");

           
            
            
            
            
            // Esercizio Range di date
            
            /*Console.WriteLine("Premendo invio verrà caricato il file JSON con le date formattate e stampato su console il giorno e numero contagi entro un certo range");
            l.JsonToList("lista.json");
            l.DateRange("01/03/20", "03/03/20");   // (data1, data2), le date devono usare la stessa formattazione delle date nel file JSON*/
        }
    }
}
