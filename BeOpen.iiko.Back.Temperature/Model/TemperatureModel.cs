using System.Collections.Generic;

namespace BeOpen.iiko.Back.Temperature.Model
{
    public class TemperatureModel
    {
        public string StoreName { get; set; }
        public string AvarageTemp { get; set; }

        public string[] GetPropertiesArr()
        {
            return new string[]
            {
                StoreName,
                AvarageTemp,
            };
        }
    }
}
