using OpenPolytechnic.Business.Factories;
using OpenPolytechnic.Business.Model.Menu;
using OpenPolytechnic.Business.Services.Interfaces;

namespace OpenPolytechnic.Business.Services
{
    public class MenuService : IMenuService
    {
        private readonly MenuFactory menuFactory;

        public MenuService()
        {
            menuFactory = new MenuFactory();
        }

        public Menu GetMenu(string menuType)
        {
            if (menuType.ToLower().Equals("weekend"))
            {
                return menuFactory.WeekendMenu();
            }
            else if (menuType.ToLower().Equals("catering"))
            {
                return menuFactory.CateringMenu();
            }
            else
            {
                return menuFactory.RegularMenu();
            }
        }
    }
}
