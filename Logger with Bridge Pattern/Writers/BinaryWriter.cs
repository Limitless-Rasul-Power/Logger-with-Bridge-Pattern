using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Logger_with_Bridge_Pattern
{    
    public class BinaryWriter : IWriter
    {
        public void Write(string data)
        {
            var bf = new BinaryFormatter();
            using (var fs = new FileStream("BinaryWriter.bin", FileMode.Append))
            {
                bf.Serialize(fs, data);
            }
        }
    }
}