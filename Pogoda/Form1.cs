using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    class WeatherInfoRaw
    {
        public WeatherInfoRawUnits current_units;
        public WeatherInfoRawData current;


        public static WeatherInfoRaw Fetch()
        {
            HttpClient client = new HttpClient();
            var res = client.GetAsync("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,rain").Result;
            string resContent = res.Content.ReadAsStringAsync().Result;

            WeatherInfoRaw raw = JsonSerializer.Deserialize<WeatherInfoRaw>(resContent);

            if(raw == null)
            {
                throw new Exception("Failed to fetch.");
            }
            
            return raw;
        }
    }

    class WeatherInfoRawUnits
    {
        public string temperature_2m { get; set; }
        public string relative_humidity_2m { get; set; }
        public string rain { get; set; }
    }

    class WeatherInfoRawData
    {
        public float temperature_2m { get; set; }
        public float relative_humidity_2m { get; set; }
        public float rain { get; set; }
    }
}
