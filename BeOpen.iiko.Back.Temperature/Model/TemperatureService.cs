using System;
using BeOpen.iiko.Back.Temperature.Properties;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using Newtonsoft.Json;
using BeOpen.iiko.Back.Temperature.DTO;

namespace BeOpen.iiko.Back.Temperature.Model
{
    public class TemperatureService : IDisposable
    {
        private HttpClient _httpClient;
        private Uri _getTemperatureUri;
        private Guid _storeId;

        public TemperatureService()
        {
            _httpClient = new HttpClient();
            _getTemperatureUri = new Uri(Settings.Default.GetTemperatureUrl);
            _storeId = new Guid(Settings.Default.StoreId);
        }
        public List<TemperatureModel> GetTemperatureData()
        {
            var getTemperatureResp = _httpClient.GetAsync(_getTemperatureUri).Result;
            if (getTemperatureResp.IsSuccessStatusCode)
            {
                var contentStr = getTemperatureResp.Content.ReadAsStringAsync().Result;
                var getTemperatureDto = JsonConvert.DeserializeObject<IEnumerable<ResponseData>>(contentStr);
                if(!getTemperatureDto.Any())
                {
                    throw new Exception($"Could not get temperature data: {getTemperatureResp.ReasonPhrase}");
                }
                if (_storeId != default)
                {
                    getTemperatureDto = new List<ResponseData>
                    {
                        getTemperatureDto.FirstOrDefault(x => new Guid(x.StoreExternalId) == _storeId)
                    };
                }

                return ConvertToModel(getTemperatureDto);
            }
            else
            {
                throw new Exception($"Could not get temperature data: {getTemperatureResp.ReasonPhrase}");
            }

        }
        public List<TemperatureModel> ConvertToModel(IEnumerable<ResponseData> data)
        {
            var result = new List<TemperatureModel>();
            foreach(var elem in data)
            {
                result.Add(new TemperatureModel
                {
                    StoreName = elem?.StoreName,
                    MinTemp = $"{elem?.TemperatureInfo.EmployeeNameMinTemp} - {elem?.TemperatureInfo.MinTemp}",
                    AvarageTemp = $"{elem?.TemperatureInfo.AverageTemp}",
                    MaxTemp = $"{elem?.TemperatureInfo.EmployeeNameMaxTemp} - {elem?.TemperatureInfo.MaxTemp}",
                });
            }

            return result;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
