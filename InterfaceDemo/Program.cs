using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ClassA();
            a.MyNumber = 5;
            a.InterfaceMethod();
            Console.Read(); 
        }
    }

    interface IShape
    {
        public int MyNumber { get; set; }
        void InterfaceMethod();
    }
}
