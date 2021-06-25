using System;
using System.Text.Json;
using task2;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            if (JsonSerializer.Deserialize(@"{""X"":1,""Y"":2}", typeof(MyClass)) is MyClass myClass)
                Console.WriteLine(myClass.X + " " + myClass.Y);
        }
    }
}