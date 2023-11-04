using System;
using System.Diagnostics;
using System.Linq;

namespace timeit
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            if (args.Length < 1)
            {
                return;
            }

            using (Process process = new())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = args[0],
                    Arguments = string.Join(" ", args.Skip(1).ToArray()),
                };

                Stopwatch stopwatch = new();
                stopwatch.Start();
                process.Start();
                process.WaitForExit();
                stopwatch.Stop();

                Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
