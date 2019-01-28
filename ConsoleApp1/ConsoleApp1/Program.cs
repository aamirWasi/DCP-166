using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                int purchased = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i < purchased; i++)
                {
                    int s;
                    string line = Console.ReadLine();
                    string[] space = line.Split(' ');
                    double p_first = double.Parse(space[0]);
                    int item = int.Parse(space[1]);
                    s = (int)Math.Ceiling(p_first * item);
                    //Console.WriteLine(s);
                    sum = sum + s;
                }
                int taka = int.Parse(Console.ReadLine());
                int r_taka = taka - sum;
                Console.WriteLine($"Case {t}: {r_taka}");
            }
        }
    }
}
