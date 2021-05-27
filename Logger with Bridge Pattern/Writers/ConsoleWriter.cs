using System;

namespace Logger_with_Bridge_Pattern
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}