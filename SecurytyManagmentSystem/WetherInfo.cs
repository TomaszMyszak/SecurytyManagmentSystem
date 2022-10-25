using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogoda
{
    internal class WetherInfo
    {
        /// <summary>
        /// generujemy klase dla koordynatow geograficznych serwisu pogody
        /// </summary>

        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        /// <summary>
        /// generujemy klase dla pobrania danych pogodowych id, nazwa, kod kraju, czas wschodu i zachodu słońca
        /// </summary>

        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }


        /// <summary>
        /// generujemy klase dla danych pogodowych takich jak temperatura,
        /// ciśnienie, wilgotność, temperatura minimalna, temperatura maksymalna, ciśnienie na poziomie morza, ciśnienie na poziomie stacji
        /// </summary>

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        /// <summary>
        /// generujemy klase dla danych pogodowych takich jak prędkość wiatru, kierunek wiatru, kierunek wiatru w stopniach, siła wiatru
        /// </summary>

        public class wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }

        /// <summary>
        /// generujemy klase dla danych pogodowych takich jak zachmurzenie, widoczność, wskaźnik opadów, wskaźnik opadów
        /// </summary>

        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }

        }

        /// <summary>
        /// tworzymy kalsę root której zdaniem twórcy jest to główna klasa w której przechowywane są wszystkie dane pogodowe
        /// </summary>

        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public string @base { get; set; }
            public main main { get; set; }
            public int visibility { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
            public int dt { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
            

        }
        
    }
}
