using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 너의_평점은
    {
        static void Main(string[] args)
        {
            int count = 20;
            double[] scores = new double[count];
            double score = 0;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split();
                score = double.Parse(line[1]);
                switch (line[2])
                {
                    case "A+":
                        scores[i] = score * 4.5;
                        sum += score;
                        break;
                    case "A0":
                        scores[i] = score * 4.0;
                        sum += score;
                        break;
                    case "B+":
                        scores[i] = score * 3.5;
                        sum += score;
                        break;
                    case "B0":
                        scores[i] = score * 3.0;
                        sum += score;
                        break;
                    case "C+":
                        scores[i] = score * 2.5;
                        sum += score;
                        break;
                    case "C0":
                        scores[i] = score * 2.0;
                        sum += score;
                        break;
                    case "D+":
                        scores[i] = score * 1.5;
                        sum += score;
                        break;
                    case "D0":
                        scores[i] = score * 1.0;
                        sum += score;
                        break;
                    case "F":
                        scores[i] = score * 0;
                        sum += score;
                        break;
                    case "P":
                        break;
                }
            }
            Console.WriteLine(Math.Round(scores.Sum() / sum, 6));
        }
    }
}
