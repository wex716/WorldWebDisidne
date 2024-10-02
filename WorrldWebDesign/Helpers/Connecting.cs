using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorrldWebDesign.Models;

namespace WorrldWebDesign.Helpers
{
    internal class Connecting
    {
        public static WorldWEbDesigneEntities conn { get; set; } = new WorldWEbDesigneEntities();
    }
}
