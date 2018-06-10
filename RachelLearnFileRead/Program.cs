using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RachelLearnFileRead.Factories;
using RachelLearnFileRead.Models;

namespace RachelLearnFileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            var avaleraProcessor = new AvaleraProcessor(@"C:/TaxReconcile/ReconcileDocumentLineDetail.csv");
            var avaleraLines = avaleraProcessor.GetAvaleraLines();
           

            var gillProcessor = new GillProcessor(@"C:/TaxReconcile/GIL.csv");
            var gillLines = gillProcessor.GetGillLines();

            var gillIds = gillLines.Select(x => x.Id).ToList();
            var avIds = avaleraLines.Select(x => x.LineValue).ToList();
            var matchingResults = avIds.Intersect(gillIds);

            Console.WriteLine("There should be " + matchingResults.Count().ToString() + " transactions.");
            var transactions = new List<TransactionsToVoid>();

            foreach (var avaleraLine in avaleraLines)
            {
                if (matchingResults.Contains(avaleraLine.LineValue))
                {
                    transactions.Add(new TransactionsToVoid(avaleraLine));
                }
            }
            TransactionReportFactory.Run(",",transactions.ToArray());


            Console.WriteLine("There are " + transactions.Count.ToString() +
                              " transactions. Your file can be found at C:/TaxReconcile/Results.csv.");
            Console.WriteLine("Enter q to quit or any key to open the result file now.");
            
            var response = Console.ReadLine();
            if(string.IsNullOrEmpty(response) || !response.ToLower()[0].Equals('q'))
                Process.Start(@"C:/TaxReconcileTestFolderCreation/Results.csv");
        }

        
    }
}
