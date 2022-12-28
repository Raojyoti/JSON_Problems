using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSON_PROBLEMS
{
    public class Operation
    {
        public void ReadJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            List<Model> data = JsonConvert.DeserializeObject<List<Model>>(json);
            Console.WriteLine("Name Weight Price Total Value");
            Console.WriteLine("------------------------------------------------------");
            foreach (var content in data)
            {
                double value = content.Price * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.Price + "   " + value);
            }
        }
        public void ReadJsonFile1(string filePath)
        {
            var json = File.ReadAllText(filePath);
            Model data = JsonConvert.DeserializeObject<Model>(json);
            List<Model> typesOfRice = data.TypesOfRice;
            List<Model> typesOfWheat = data.TypesOfWheat;
            List<Model> typesOfPulses = data.TypesOfPulses;
            Console.WriteLine("TypeOfRice Weight Price Total Value");
            Console.WriteLine("------------------------------------------------------");
            foreach (var content in typesOfRice)
            {
                double value = content.Price * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.Price + "   " + value);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("TypeOfRice Weight Price Total Value");
            foreach (var content in typesOfWheat)
            {
                double value = content.Price * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.Price + "   " + value);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("TypeOfRice Weight Price Total Value");
            foreach (var content in typesOfWheat)
            {
                double value = content.Price * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.Price + "   " + value);
            }
        }
        public void ReadJsonFile2(string filePath)
        {
            var json = File.ReadAllText(filePath);
            Model data = JsonConvert.DeserializeObject<Model>(json);
            List<Model> stockReport = data.StockReport;
            Console.WriteLine("Name NumberOfShares Price TotalValue");
            Console.WriteLine("------------------------------------------------------");
            foreach (var content in stockReport)
            {
                double value = content.Price * content.NumberOfShares;
                Console.WriteLine(content.Name + "   " + content.NumberOfShares + "   " + content.Price + "   " + value);
            }
        }
    }
}
