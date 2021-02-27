using System;
using System.Collections.Generic;
using System.Text;

namespace Grimaldi.Leonardo._4J.Contagi
{
    class Giorno
    {
        string formatoData;
        public string FormatoData
        {
            get { return formatoData; }
            set { formatoData = value; }
        }
        /*DateTime data = new DateTime();
        public DateTime Data
        {
            get { return data; }
            set 
            {
                data = value;
            }
        }*/

        string data;
        public string Data
        {
            get { return data; }
            set {
                if (formatoData == "it")
                {
                    data = value;
                }
                else
                {
                    DateTime dt = DateTime.ParseExact(value, "M/d/yy", System.Globalization.CultureInfo.InvariantCulture);  // M/d/yy perche sul json di input le date sono scritte cosi "1/27/20" e non "01/27/20"
                    data = dt.ToString("dd/MM/yy"); // la data viene salvata in formato string formattato secondo lo standard italiano
                    formatoData = "it";
                }
                
            }
        }



        int progressivo;
        public int Progressivo
        {
            get { return progressivo; }
            set { progressivo = value; }
        }

        int contagi;
        public int Contagi
        {
            get { return contagi; }
            set { contagi = value; }
        }
        public Giorno()
        {

        }

    }
}
