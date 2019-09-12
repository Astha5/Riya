using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaiy
{
    class Sample
    {
        public async Task<long> SumofNatutalNumbers(int n)
        {
            long sum=0;
            await Task.Run(()=> {
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + i;
                }
            });
            
            return sum;
        }
    }
    class Program
    {
        static async Task Main()
        {
            Sample sample = new Sample();
            long s=await sample.SumofNatutalNumbers(5);
            Console.WriteLine("Continue------------");
            Console.WriteLine($"sum is {s}");
            Console.ReadKey();

        }
    }
}
