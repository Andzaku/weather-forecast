using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using System.Net;
using Microsoft.VisualBasic;
using GeoTimeZone;

namespace Weather_Forecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "dc6f2a28ec56cd9e5f24bcbf3d3f4ac9";


        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {

                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", citytextbox.Text, APIKey);
                    var json = web.DownloadString(url);
                    Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json);

                    iconbox.ImageLocation = "C:\\Users\\andre\\source\\repos\\WeatherForecast\\Pictures\\Sun.gif";

                    double latitude = Info.coord.lat;
                    double longitude = Info.coord.lon;
                    double temperatureKelvin = Info.main.temp;
                    double temperatureCelsius = temperatureKelvin - 273.15;

                    string timeZoneId = TimeZoneLookup.GetTimeZone(latitude, longitude).Result;
                    TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone);
                    timelabel.Text = localTime.ToString("HH:mm:ss");

                    tmpoutput.Text = $"{temperatureCelsius:N2} °C";
                    humidityoutput.Text = $"{Info.main.humidity.ToString()} %";
                    windoutput.Text = $"{Info.wind.speed.ToString()} km/h";
                    cloudsoutput.Text = $"{Info.weather[0].description}";
                    sunriseoutput.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                    sunsetoutput.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        
            DateTime convertDateTime(long sec)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(sec).ToLocalTime();
                return day;
            }
        }
            

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}