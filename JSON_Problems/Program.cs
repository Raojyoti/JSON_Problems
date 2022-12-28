using System;

namespace JSON_PROBLEMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation json = new Operation();
            json.ReadJsonFile("E:\\Update_JSON_Problem\\JSON_Problems\\JSON_Problems\\Inventory.json");
            json.ReadJsonFile1("E:\\Update_JSON_Problem\\JSON_Problems\\JSON_Problems\\SecondInventory.json");
            json.ReadJsonFile2("E:\\Update_JSON_Problem\\JSON_Problems\\JSON_Problems\\SecondInventory.json");
        }
    }
}
