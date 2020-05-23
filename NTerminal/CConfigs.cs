using System.Collections.Generic;
using System.Drawing;

namespace NTerminal
{
    public class CConfigs
    {
        public CConfigs()
        {
            Items = new List<CItems>();
            FML = new Point();
        }

        public List<CItems> Items { get; set; }

        public Point FML { get; set; }
    }
}
