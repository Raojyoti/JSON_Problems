using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_PROBLEMS
{
    public class Model
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public int NumberOfShares { get; set; }
        public List<Model> TypesOfRice { get; set; }
        public List<Model> TypesOfWheat { get; set; }
        public List<Model> TypesOfPulses { get; set; }
        public List<Model> StockReport { get; set; }
    }
}
