using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AICorporation.Bulldozer.BulldozerBuilderLibrary;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.CustomExceptions;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Entities;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Enums;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Factories;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces;


namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = DataMapping.GetCSharpDataMap().MappedDataTypes;
            foreach(var item in items)
            {
                Console.WriteLine($"{item.Key} {item.Value.SQLDataTypeName} -> {item.Value.CommonName} ");
            }
            Complete();
        }
        public static void Complete()
        {
            Console.WriteLine("Task Complete");
            Console.ReadKey();
        }
    }
}
