using Resto.BackApi.Core;
using System.Windows.Forms;
using BeOpen.iiko.Back.Temperature.View;
using BeOpen.iiko.Back.Temperature.Presenter;
using BeOpen.iiko.Back.Temperature.Model;

namespace BeOpen.iiko.Back.Temperature
{
    public class TemperatureTab : PluginTabPageBase
    {
        public TemperatureTab() : base("Temperature")
        {
        }
        public override UserControl CreateControl()
        {
            var control = new TemperatureView();
            var service = new TemperatureService();
            var presenter = new TemperaturePresenter(control, service);

            return control;
        }
        public override string GetTabPageId()
        {
            return "BeOpen_Temperature";
        }
        public override bool Closed(UserControl control)
        {
            return base.Closed(control);
        }
    }
}
