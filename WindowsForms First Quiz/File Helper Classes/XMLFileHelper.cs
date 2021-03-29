using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsForms_First_Quiz.Entity_Classes;

namespace WindowsForms_First_Quiz
{
    public static class XMLFileHelper
    {
        #region XMLSerialization
        public static void XMLSerialize(List<QuestionBlock> qb, string fileName)
        {
            if (!Directory.Exists("Questions"))
                Directory.CreateDirectory("Questions");

            if (!string.IsNullOrWhiteSpace(fileName))
            {
                var xml = new XmlSerializer(typeof(List<QuestionBlock>));
                using (var fs = new FileStream($"Questions/{fileName}.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, qb);
                }
            }
        }
        public static void XMLDeSerialize<T>(ref List<T> datas, string fileName)
        {
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                if (File.Exists(fileName))
                {
                    var xml = new XmlSerializer(typeof(List<T>));
                    using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        datas = xml.Deserialize(fs) as List<T>;
                    }
                }                
            }
        }

        

        #endregion
    }

}
