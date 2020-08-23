using BeOpen.iiko.Back.Temperature.Model;
using System;
using System.Collections.Generic;

namespace BeOpen.iiko.Back.Temperature.View
{
    public interface ITemperatureView
    {
        event Action HardRefresh;
        event Action StoreChanged;

        void RefreshData(List<TemperatureModel> temperatureData);
        void ChangeTableData(List<TemperatureModel> temperatureData);
    }
}
