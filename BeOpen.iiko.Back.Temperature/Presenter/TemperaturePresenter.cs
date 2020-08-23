using BeOpen.iiko.Back.Temperature.Model;
using BeOpen.iiko.Back.Temperature.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BeOpen.iiko.Back.Temperature.Presenter
{
    public class TemperaturePresenter
    {
        private ITemperatureView _view;
        private TemperatureService _temperatureService;
        private List<TemperatureModel> _cachedData;

        public TemperaturePresenter(ITemperatureView view, TemperatureService temperatureService)
        {
            _view = view;
            _temperatureService = temperatureService;

            _view.HardRefresh += () => RefreshViewData();
            _view.StoreChanged += () => RemindViewData();

            RefreshViewData();
        }
        public void RefreshViewData()
        {
            try
            {
                var data = _temperatureService.GetTemperatureData();
                _cachedData = data;

                _view.RefreshData(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Could not get data {ex.Message}");
            }
        }
        public void RemindViewData()
        {
            if (_cachedData != null && _cachedData.Count > 0)
            {
                _view.ChangeTableData(_cachedData);
            }
            else
            {
                RefreshViewData();
            }
        }
    }
}
