using System;

namespace Red7
{
    public class Screen
    {
        private Action write;

        private void WriteHello()
        {
            Console.WriteLine("Hello");
            write = WriteWorld;
        }

        private void WriteWorld()
        {
            Console.WriteLine("World");
            write = WriteHello;
        }

        public void Try()
        {
            write = WriteHello;
            write();
            write();
            write();
            write();
        }
    }
}