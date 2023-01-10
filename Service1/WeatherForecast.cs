namespace Service1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        private int TempC;
        public int TemperatureC
        {
            get { return TempC; }
            set { TempC = value; }
        }
        public int TemperatureF
        {
            get { return TempC*2; }
            set { TempC = value/2; }
        }
        public string? Summary { get; set; }
    }
}