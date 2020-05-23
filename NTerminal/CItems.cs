using System.Collections.Generic;

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
