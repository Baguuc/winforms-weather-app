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

    class WeatherInfo
    {
        private Scalar<float> temperature { get; }
        private Scalar<float> humidity { get; }
        private Scalar<float> rain { get; }

        public WeatherInfo(Scalar<float> temperature, Scalar<float> humidity, Scalar<float> rain)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.rain = rain;
        }

        public WeatherInfo FromRaw(WeatherInfoRaw raw)
        {
            Scalar<float> temperature = new Scalar<float>(raw.current_units.temperature_2m, raw.current.temperature_2m);
            Scalar<float> humidity = new Scalar<float>(raw.current_units.relative_humidity_2m, raw.current.relative_humidity_2m)
            Scalar<float> rain = new Scalar<float>(raw.current_units.rain, raw.current.rain);

            WeatherInfo data = new WeatherInfo(
                temperature,
                humidity,
                rain
            );

            return data;
        }
    }

    class Scalar<T>
    {
        private string unit;
        private T value;

        public Scalar(string unit, T value)
        {
            this.unit = unit;
            this.value = value;
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
