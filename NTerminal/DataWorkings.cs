using System.Windows.Forms;
using System;

namespace NTerminal
{
    public static class DataWorkings
    {
        public static CConfigs Config { get; set; } = new CConfigs();

        public static string FileConfig { get; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\nter.cfg";

        public static void WriteConfig()
        {
            if(!CJsonWorkings.Write(DataWorkings.Config, DataWorkings.FileConfig))
            {
                MessageBox.Show("không thể ghi file cấu hình");
            }
        }
    }
}
