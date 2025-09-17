using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _121_BestTimetoBuyandSellStock
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                int min = int.MaxValue;
                int profit = 0;

                foreach (var cost in prices)
                {
                    min = Math.Min(min, cost);
                    profit = Math.Max(profit, cost - min);
                }

                return profit;
            }
        }
    }
}
