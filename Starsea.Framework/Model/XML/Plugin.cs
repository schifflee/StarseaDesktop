using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Framework.Model.XML
{
    [Serializable]
    public class Plugin
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }

        public UI UI { get; set; }

        public Componentes Componentes { get; set; }

    }

  

    public class UI
    {
        public Ribbon Ribbon { get; set; }
    }

    public class Componentes
    {
    }
}
