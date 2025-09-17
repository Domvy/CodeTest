using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _118_Pascal_sTriangle
    {
        public class Solution
        {
            public IList<IList<int>> Generate(int numRows)
            {
                IList<IList<int>> result = new List<IList<int>>();

                for (int i = 0; i < numRows; i++)
                {
                    List<int> list = new List<int>();
                    for (int j = 0; j < i + 1; j++)
                    {
                        if (j == 0)
                        {
                            list.Add(1);
                        }
                        else if (j == i)
                        {
                            list.Add(1);
                        }
                        else
                        {
                            list.Add(result[i - 1][j - 1] + result[i - 1][j]);
                        }
                    }

                    result.Insert(i, list);
                }
                
                return result;
            }
        }
    }
}
