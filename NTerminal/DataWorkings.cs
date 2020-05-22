using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTerminal
{
    public static class DataWorkings
    {
        public static CConfigs Config { get; set; } = new CConfigs();

        public static string FileConfig { get; } = @"config.json";

        public static void WriteConfig()
        {
            if(!CJsonWorkings.Write(DataWorkings.Config, DataWorkings.FileConfig))
            {
                MessageBox.Show("không thể ghi file");
            }
        }
    }
}
