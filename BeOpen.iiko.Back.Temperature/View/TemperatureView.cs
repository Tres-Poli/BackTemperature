using BeOpen.iiko.Back.Temperature.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BeOpen.iiko.Back.Temperature.View
{
    public partial class TemperatureView : UserControl, ITemperatureView
    {
        public TemperatureView()
        {
            InitializeComponent();

            btnRefresh.Click += (sender, obj) =>
            {
                HardRefresh.Invoke();
                MessageBox.Show("Refreshed");
            };
            cmboBoxStores.SelectedIndexChanged += (sender, obj) =>
            {
                StoreChanged.Invoke();
            };
        }

        public event Action HardRefresh;
        public event Action StoreChanged;

        public void RefreshData(List<TemperatureModel> temperatureData)
        {
            cmboBoxStores.DataSource = temperatureData.Select(x => x.StoreName).ToList();
            var currElem = temperatureData.ElementAt(cmboBoxStores.SelectedIndex);
            FillAndRefreshTable(currElem);

            cmboBoxStores.Refresh();
        }
        public void ChangeTableData(List<TemperatureModel> temperatureData)
        {
            var currElem = temperatureData.ElementAt(cmboBoxStores.SelectedIndex);
            FillAndRefreshTable(currElem);
        }

        private void FillAndRefreshTable(TemperatureModel data)
        {
            lblStoreNameVal.Text = data.StoreName;
            lblMinTempVal.Text = data.MinTemp;
            lblAvrgTempVal.Text = data.AvarageTemp;
            lblMaxTempVal.Text = data.MaxTemp;

            lblStoreNameVal.Refresh();
            lblMinTempVal.Refresh();
            lblAvrgTempVal.Refresh();
            lblMaxTempVal.Refresh();
        }
    }
}
