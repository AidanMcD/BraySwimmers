using System;
using System.Collections.Generic;
using Services.Interface;

namespace Services
{
    public class WeatherDataStrategy: IDataStrategy
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        string IDataStrategy.GetData(Dictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
