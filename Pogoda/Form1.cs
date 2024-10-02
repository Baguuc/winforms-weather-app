using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.UpdateWeatherData();
        }

        private void UpdateWeatherData()
        {
            WeatherInfoRaw raw = WeatherInfoRaw.Fetch();
            WeatherInfo weather = WeatherInfo.FromRaw(raw);

            this.TemperatureValueLabel.Text = weather.GetTemperature().ToString();
            this.HumidityValueLabel.Text = weather.GetHumidity().ToString();
            this.RainValueLabel.Text = weather.GetRain().ToString();
        }

        private void WeatherTimerTick(object sender, EventArgs e)
        {
            this.UpdateWeatherData();
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

        public static WeatherInfo FromRaw(WeatherInfoRaw raw)
        {
            Scalar<float> temperature = new Scalar<float>(raw.current_units.temperature_2m, raw.current.temperature_2m);
            Scalar<float> humidity = new Scalar<float>(raw.current_units.relative_humidity_2m, raw.current.relative_humidity_2m);
            Scalar<float> rain = new Scalar<float>(raw.current_units.rain, raw.current.rain);

            WeatherInfo data = new WeatherInfo(
                temperature,
                humidity,
                rain
            );

            return data;
        }

        public Scalar<float> GetTemperature()
        {
            return this.temperature;
        }

        public Scalar<float> GetHumidity()
        {
            return this.humidity;
        }

        public Scalar<float> GetRain()
        {
            return this.rain;
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
        
        public string GetUnit()
        {
            return this.unit;
        } 
        
        public T GetValue()
        {
            return this.value;
        }

        public string ToString()
        {
            return this.value + this.unit;
        }
    }

    class WeatherInfoRaw
    {
        public WeatherInfoRawUnits current_units { get; set; }
        public WeatherInfoRawData current { get; set; }


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
