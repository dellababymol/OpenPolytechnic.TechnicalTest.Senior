using OpenPolytechnic.Business.Model.Menu;

namespace OpenPolytechnic.Business.Services.Interfaces
{
    public interface IMenuService
    {
        public Menu GetMenu(string menuType);
    }
}
