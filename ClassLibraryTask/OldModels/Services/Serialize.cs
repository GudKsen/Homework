using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibraryTask.Models
{
    internal class Serialize<T>
    {
        public string SerializeJSON(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        public T DeserializeJSON(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }

        public void SerializeXML(Stream fs, T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            //XmlWriter xmlWriter = new XmlTextWriter(fs, Encoding.UTF8);
            XmlWriter xmlWriter = XmlWriter.Create(fs);
            
            xmlSerializer.Serialize(xmlWriter, obj);
            xmlWriter.Close();
        }

        public T DeserializeXML(string str)
        {
            using (TextReader reader = new StringReader(str))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(reader);
            }
        }
    }
}
