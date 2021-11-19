using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram
{
    class StockPortfolio
    {
        public string Stock { get; set; }
        public int NoOfStocks { get; set; }
        public int PricePerStock { get; set; }

        internal static void DisplayData(string v)
        {
            throw new NotImplementedException();
        }
    }
}
