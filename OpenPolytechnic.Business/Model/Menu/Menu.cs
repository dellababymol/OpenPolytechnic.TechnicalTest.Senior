using System.Collections.Generic;

namespace OpenPolytechnic.Business.Model.Menu
{
    public class Menu
    {
        public string Name { get; set; }
        public IEnumerable<MenuItem> Items { get; set; }
    }
}
