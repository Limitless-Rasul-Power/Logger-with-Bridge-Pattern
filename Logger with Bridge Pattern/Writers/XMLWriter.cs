using System.IO;
using System.Xml.Serialization;

namespace Logger_with_Bridge_Pattern
{
    public class XMLWriter : IWriter
    {
        public void Write(string data)
        {
            var xml = new XmlSerializer(typeof(string));
            using (var fs = new FileStream("XMLWriter.xml", FileMode.Append))
            {
                xml.Serialize(fs, data);
            }
        }
    }
}