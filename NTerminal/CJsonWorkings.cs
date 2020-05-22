using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace NTerminal
{
    public static class CJsonWorkings
    {
        /// <summary>
        /// Ghi file Json
        /// </summary>
        /// <param name="data">dữ liệu ghi vào</param>
        /// <param name="jsonFilePath">địa chỉ lưu file Json</param>
        /// <returns>trả về true nếu thành công</returns>
        public static bool Write(object data, string jsonFilePath)
        {
            try
            {
                DataContractJsonSerializer ser2 = new DataContractJsonSerializer(data.GetType());
                MemoryStream stream2 = new MemoryStream();
                ser2.WriteObject(stream2, data);
                File.WriteAllBytes(jsonFilePath, stream2.ToArray());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy dữ liệu từ file Json
        /// </summary>
        /// <param name="type">kiểu dữ liệu trả về</param>
        /// <param name="jsonFilePath">địa chỉ file Json</param>
        /// <returns>trả về null nếu không đọc được hoặc dữ liệu không có</returns>
        public static object Read(Type type, string jsonFilePath)
        {
            try
            {
                MemoryStream stream1 = new MemoryStream(File.ReadAllBytes(jsonFilePath));
                stream1.Position = 0;
                System.Runtime.Serialization.Json.DataContractJsonSerializer ser1 = new DataContractJsonSerializer(type);
                return ser1.ReadObject(stream1);
            }
            catch
            {
                return null;
            }
        }
    }
}
