using Newtonsoft.Json;
using System.IO;

namespace Logger_with_Bridge_Pattern
{
    public class JsonWriter : IWriter
    {
        public void Write(string data)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("JsonWriter.json", true))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, data);
                }
            }
        }
    }
}