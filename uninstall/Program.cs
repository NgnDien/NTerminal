using System;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace uninstall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uninstall NTer";
            Console.OutputEncoding = Encoding.UTF8;
            
            string fiw = $"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\\nter.exe";
            Console.WriteLine("> Xóa %windir%\\nter.exe");
            if(File.Exists(fiw))
            {
                try
                {
                    File.Delete(fiw);
                }
                catch
                {
                    Console.WriteLine("Không thể xóa file");
                    FailureMsg();
                    return;
                }
            }
            Console.WriteLine("> Xóa Registry");
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                regKey.DeleteValue("nter", false);
            }
            catch
            {
                Console.WriteLine("Không thể xóa registry");
                FailureMsg();
                return;
            }
            Console.WriteLine("Gỡ chương trình thành công");
            Console.ReadKey();
            return;
        }

        private static void FailureMsg()
        {
            Console.WriteLine("\nGỡ chương trình không thành công\nNhấn phím bất kì để thoát");
            Console.ReadKey();
        }
    }
}
