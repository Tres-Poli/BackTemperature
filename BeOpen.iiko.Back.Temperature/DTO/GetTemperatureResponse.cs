using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BeOpen.iiko.Back.Temperature.DTO
{
    public class ResponseData
    {
        [JsonProperty("checkDate")]
        public DateTime CheckDate { get; set; }
        [JsonProperty("storeName")]
        public string StoreName { get; set; }
        [JsonProperty("storeExternalId")]
        public string StoreExternalId { get; set; }
        [JsonProperty("temperatureInfo")]
        public TemperatureInfo TemperatureInfo { get; set; }
    }

    public class TemperatureInfo
    {
        [JsonProperty("averageTemp")]
        public float AverageTemp { get; set; }
        [JsonProperty("maxTemp")]
        public float MaxTemp { get; set; }
        [JsonProperty("employeeNameMaxTemp")]
        public string EmployeeNameMaxTemp { get; set; }
        [JsonProperty("employeeIdMaxTemp")]
        public string EmployeeIdMaxTemp { get; set; }
        [JsonProperty("minTemp")]
        public float MinTemp { get; set; }
        [JsonProperty("employeeNameMinTemp")]
        public string EmployeeNameMinTemp { get; set; }
        [JsonProperty("employeeIdMinTemp")]
        public string EmployeeIdMinTemp { get; set; }
    }
}
