using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NTerminal
{
    public class CItems
    {
        public CItems()
        {
            SubItems = new List<CItems>();
        }
        public string HT { get; set; }

        public string DC { get; set; }

        public string MT { get; set; }

        public List<CItems> SubItems { get; set; }
    }
}
