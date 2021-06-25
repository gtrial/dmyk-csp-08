using System;
using System.Text.Json;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            var myClass = new MyClass(1, 2);
            var myClassJson = JsonSerializer.Serialize(myClass, myClass.GetType());
            Console.WriteLine(myClassJson);
            if (JsonSerializer.Deserialize(myClassJson, typeof(MyClass)) is MyClass myClass2)
                Console.WriteLine(myClass2.X + " " + myClass2.Y);
        }
    }

    [Serializable]
    public class MyClass
    {
        public int X { get; }
        public int Y { get; }

        public MyClass(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}