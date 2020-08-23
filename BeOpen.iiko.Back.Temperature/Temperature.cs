using System.Collections.Generic;
using System.Linq;
using Resto.Data;
using Resto.Framework.Data;
using Resto.BackApi.Core;
using Resto.BackApi.Core.Plugin;

namespace BeOpen.iiko.Back.Temperature
{
    public class Temperature : INavBarPlugin
    {
        public MenuGroup MenuGroup
        {
            get
            {
                var user = EntityManager.INSTANCE.GetAll<User>().FirstOrDefault(u => u.LoginName == User.GetCurrentLogin());
                if (user == null || (!user.IsAdministrator && !user.Roles.Any(r => r.Code == "ACS")))
                    return null;

                var menuItems = new List<BaseMenuItem>();
                menuItems.Add(new MenuItem(tabPage: new TemperatureTab(), qualifyingId: "Temperature"));

                return new MenuGroup("Temperature", menuItems.ToArray(), "Temperature", null);
            }
        }
        public void SetAdapter(IPluginAdapter adapter)
        {

        }
    }
}
