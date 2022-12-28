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
    }
}
