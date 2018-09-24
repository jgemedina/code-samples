using System;
using System.Linq;
using System.Collections.Generic;

namespace MontyHall
{
    using Model;
    using Actor;

    class Program
    {
        static void Main(string[] args)
        {
            int runs = 1000;
            PerformRuns(runs, out ICollection<ContestResult> results);

            PrintResults(runs, results);

            Console.WriteLine("\n\rPress any key to terminate...");
            Console.ReadKey();
        }

        private static void PerformRuns(int runCount, out ICollection<ContestResult> results)
        {
            var host = new Host();
            var contestant = new Contestant();

            results = new List<ContestResult>(runCount);
            for (var i = 0; i < runCount; i++)
            {
                var session = new ContestRun(host, contestant);
                ContestResult result = session.Run();
                Console.WriteLine(result);
                results.Add(result);
            }            
        }

        private static void PrintResults(int total, ICollection<ContestResult> results)
        {
            Console.WriteLine($"\n\rNumber of runs: {total}");
            Console.WriteLine("When the contestant decided to stay, percentages are:");
            PrintSubResults(results.Where(i => i.ContestantDecision == ContestantDecision.Stay));

            Console.WriteLine("\n\rWhen the contestant decided to change choice, percentages are:");
            PrintSubResults(results.Where(i => i.ContestantDecision == ContestantDecision.Change));
        }

        private static void PrintSubResults(IEnumerable<ContestResult> subset)
        {
            int total = subset.Count(),
                winCount = subset.Count(i => i.ChoiceOutcome == ChoiceOutcome.Won),
                lostCount = subset.Count(i => i.ChoiceOutcome == ChoiceOutcome.Lost);

            Console.WriteLine(string.Format("Win: {0:0.00%}", (float)winCount / total));
            Console.WriteLine(string.Format("Lost: {0:0.00%}", (float)lostCount / total));            
        }
    }
}
