using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using RachelLearnFileRead.Models;

namespace RachelLearnFileRead.Factories
{
    public class AvaleraProcessor
    {
        private const string RequiredHeader =
            "Company,DocumentCodeValue,DocumentDateValue,Region_1,TotalSalesAmount_Sum,TotalDiscountAmount_Sum,TotalExempt_Sum,TaxableSales_Sum,TotalSalesTaxAmount_Sum,Region,LineValue,ItemValue,TaxCodeValue,QuantityValue,LineAmountValue,DiscountAmountValue,ExemptAmountValue,TaxableAmountValue,TaxValue,CompanyTotal_TotalSalesAmount,CompanyTotal_TotalDiscountAmount,CompanyTotal_TotalExempt,CompanyTotal_TaxableSales,CompanyTotal_TotalSalesTaxAmount,GrandTotal_TotalAmount,GrandTotal_DiscountAmount,GrandTotal_TotalExempt,GrandTotal_TotalTaxable,GrandTotal_TotalTax";
        private List<AvaleraLine> _avaleraLines;
        private string _path;

        public AvaleraProcessor(string path)
        {
            _path = path;
            _avaleraLines = new List<AvaleraLine>();
        }

        public List<AvaleraLine> GetAvaleraLines()
        {
            GetLinesFromInputFile();
            return _avaleraLines;
        }

        private void GetLinesFromInputFile()
        {
            using (var streamReader = new StreamReader(_path))
            {
                var headers = streamReader.ReadLine();
                if (!IsHeaderGood(headers))
                {
                    Console.WriteLine("This file isn't in the required format for Avalera input");
                    Console.WriteLine("Headers should be:\n" + RequiredHeader);
                    Console.WriteLine("Your header looks like:\n" + headers);
                    return;
                }
                   
                string line;
                while ((line = streamReader.ReadLine()) != null)// && _avaleraLines.Count < 500)
                {
                    var cleaned = CleanOutMoneyCommas(line);
                    _avaleraLines.Add(new AvaleraLine(cleaned.Split(',')));
                }
            }
        }

        private bool IsHeaderGood(string firstLine) => firstLine.Contains(RequiredHeader);

        private string CleanOutMoneyCommas(string input) => new Regex("\".*?\"").Replace(input, string.Empty);

    }
}