using System;

namespace YYX.WeirdInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorage storage = new SpecificStorage();
            const string key = @"yinyongxian";
            storage.SetValue(key, "有钱人");
            var value = storage.GetValue(key);
            Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
