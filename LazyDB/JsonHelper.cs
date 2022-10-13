using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyDB
{
    public static class JsonHelper
    {
        /// <summary>
        /// 读取配置JSON文件
        /// </summary>
        public static SystemConfigModel ReadConfigJson()
        {
            try
            {
                string jsonfile = Application.StartupPath + "\\SystemConfig.json";//JSON文件路径

                if (!File.Exists(jsonfile))
                {
                    File.Create(jsonfile);
                }
                using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject jobject = (JObject)JToken.ReadFrom(reader);
                        return JsonConvert.DeserializeObject<SystemConfigModel>(jobject.ToString());
                    }
                }
            }
            catch (Exception)
            {
                return new SystemConfigModel();
            }
        }

        public static bool WriteFile(string fileContent)
        {
            string FilePath = Application.StartupPath;
            StreamWriter TxtWriter = new StreamWriter(FilePath + "\\SystemConfig.json", false, System.Text.Encoding.UTF8);
            TxtWriter.Write(fileContent + Environment.NewLine);
            TxtWriter.Close();
            return true;
        }
    }
    public class ShortDateTimeConverter : DateTimeConverterBase
    {
        private static IsoDateTimeConverter dtConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" };

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return dtConverter.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            dtConverter.WriteJson(writer, value, serializer);
        }
    }

    public class LongDateTimeConverter : DateTimeConverterBase
    {
        private static IsoDateTimeConverter dtConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return dtConverter.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            dtConverter.WriteJson(writer, value, serializer);
        }
    }
}
