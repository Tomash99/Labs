using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1. Read matrix from file");
            Console.WriteLine($"2. Random data");
            var decision = Convert.ToInt32(Console.ReadLine());
            var loader = new Loader();
            switch (decision)
            {
                case 1:
                    Console.WriteLine($"Enter name of matrix(without txt):");
                    var name = Console.ReadLine();
                    var data = loader.ReadFromFile($"{name}.txt");
                    if (data.Cities == 0)
                    {
                        Console.ReadKey();
                        return;
                    }
                    var solver = new BBAlgorithm(data);
                    var sw = new Stopwatch();
                    sw.Start();
                    solver.Solve();
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);
                    break;

                case 2:
                    Console.WriteLine($"Size of matrix ");
                    var cities = Convert.ToInt32(Console.ReadLine());
                    var dataa = loader.RandomFile(cities);
                    var solver2 = new BBAlgorithm(dataa);
                    var sww = new Stopwatch();
                    sww.Start();
                    solver2.Solve();
                    sww.Stop();
                    Console.WriteLine(sww.Elapsed);
                    break;
               

                default:
                    Console.WriteLine($"Choose the command");
                    break;
            }
            
            Console.ReadKey();

        }
    }
}
