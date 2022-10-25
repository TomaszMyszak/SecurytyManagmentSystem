using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using pogoda;



namespace SecurytyManagmentSystem
{
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
            ///użyjemy metody getWeather() do pobrania danych pogodowych
            getWeather();
        }

        


        
        void getWeather()
        {

            /// <summary>
            /// ta metoda pobiera dane pogodowe z serwisu pogodowego z pliku JSON i przypisuje je do odpowiednich zmiennych
            /// </summary>
            /// <param name="url">https://api.openweathermap.org/data/2.5/weather?q=Katowice&appid=6c6141b28f4f15cd91e691b478cf268a</param>
            using (WebClient web = new WebClient())
            {
                string APIkey = "6c6141b28f4f15cd91e691b478cf268a";
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?q=" + "Tarnowskie Góry" + "&appid=" + APIkey); //wstawiamy nazwę miasta(0) i klucz API (1)

                string json = web.DownloadString(url);                                                                                  /// <summary>
                                                                                                                                        ///pobieramy dane z serwisu pogodowego w formacie JSON
                WetherInfo.root Info = JsonConvert.DeserializeObject<WetherInfo.root>(json);                                         ///przypisujemy pobrane dane do zmiennej root
                labConditions.Text = Info.weather[0].main;                                                                           ///przypisujemy pobrane dane do zmiennej description
                
                labPressure.Text = Info.main.pressure.ToString() + " hPa";                                                               ///przypisujemy pobrane dane do zmiennej pressure
                labWindSpeed.Text = Info.wind.speed.ToString() + " m/s";                                                               ///przypisujemy pobrane dane do zmiennej speed
                labTemp.Text = Info.main.temp.ToString() + " °K";                                                                     ///przypisujemy pobrane dane do zmiennej temp

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fireCentralForm openForm2 = new fireCentralForm();
            openForm2.Show();
        }
    }
}


