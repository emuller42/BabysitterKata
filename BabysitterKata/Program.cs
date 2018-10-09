using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            PayCalculator payCalculator = new PayCalculator();
            int pay = payCalculator.GetTotalPay(args);
            Console.Write("Total pay: $" + pay);
        }
    }
}
