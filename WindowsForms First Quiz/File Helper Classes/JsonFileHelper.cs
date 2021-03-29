using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_First_Quiz.File_Helper_Classes
{
    public static class JsonFileHelper
    {
        #region JSON        

        public static void JSONSerialization<T>(List<T> datas, string fileName)
        {
            if ((!string.IsNullOrWhiteSpace(fileName)) && datas != null)
            {
                var serializer = new JsonSerializer();

                using (var sw = new StreamWriter($"{fileName}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;
                        serializer.Serialize(jw, datas);
                    }
                }
            }

        }

        public static void JSONDeSerialization<T>(ref List<T> datas, string fileName)
        {
            if (File.Exists($"{fileName}.json"))
            {
                var serializer = new JsonSerializer();

                using (var sr = new StreamReader($"{fileName}.json"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        datas = serializer.Deserialize<List<T>>(jr);
                    }
                }
            }
        }


        public static void JSONSerialization<T>(T data, string fileName)
        {
            if ((!string.IsNullOrWhiteSpace(fileName)) && data != null)
            {
                var serializer = new JsonSerializer();

                using (var sw = new StreamWriter($"{fileName}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;
                        serializer.Serialize(jw, data);
                    }
                }
            }

        }

        public static void JSONSerialization(Database database, string fileName)
        {
            if ((!string.IsNullOrWhiteSpace(fileName)) && database != null)
            {
                if (!Directory.Exists("Database"))
                    Directory.CreateDirectory("Database");

                var serializer = new JsonSerializer();

                using (var sw = new StreamWriter($"Database/{fileName}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;
                        serializer.Serialize(jw, database);
                    }
                }
            }

        }

        public static void JSONDeSerialization(ref Database database, string fileName)
        {
            if (Directory.Exists("Database"))
            {
                var serializer = new JsonSerializer();

                if (File.Exists($"Database/{fileName}.json"))
                {
                    using (var sr = new StreamReader($"Database/{fileName}.json"))
                    {
                        using (var jr = new JsonTextReader(sr))
                        {
                            database = serializer.Deserialize<Database>(jr);
                        }
                    }
                }
            }
        }

        #endregion
    }

}
