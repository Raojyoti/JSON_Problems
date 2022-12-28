using System;

namespace JSON_PROBLEMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation json = new Operation();
            json.ReadJsonFile("E:\\JSON_Problems\\JSON_PROBLEMS\\Inventory.json");
        }
    }
}
