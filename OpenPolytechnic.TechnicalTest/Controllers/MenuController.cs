using Microsoft.AspNetCore.Mvc;
using OpenPolytechnic.Business.Model.Menu;
using OpenPolytechnic.Business.Services.Interfaces;

namespace OpenPolytechnic.TechnicalTest.Controllers
{
    [ApiController]
    [Route("api/menu")]
    public class MenuController
    {
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        [HttpGet]
        [Route("{menuType}")]
        public Menu GetMenu(string menuType)
        {
            return menuService.GetMenu(menuType);
        }
    }
}
