using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RachelLearnFileRead.Models;

namespace RachelLearnFileRead.Factories
{
    public class GillProcessor
    {
        private const string RequiredHeader =
            "doc_code,committed_date,invoice_creation_date,invoice_id,invoice_type,payment_id,payment_status,amount,direction,sales_tax_payment_in_gil,sales_tax_line_item_in_gil,task_id,job_id,name,state";
            
        
        private const string Refund = "refund";
        private static string Void = "Void";

        private List<string> _rawLines;
        public List<GillLine> _gillLines;

        private string _path;

        public GillProcessor(string path)
        {
            _path = path;
             _gillLines = new List<GillLine>();
        }

        public List<GillLine> GetGillLines()
        {
            CreateRefundTransactionListFromCsv();
            return _gillLines;
        }

        private void CreateRefundTransactionListFromCsv()
        {
            using (var streamReader = new StreamReader(_path))
            {
                var headers = streamReader.ReadLine();
                if (!IsHeaderGood(headers))
                {
                    Console.WriteLine("This file isn't in the required format for Gill input");
                    Console.WriteLine("Headers should be:\n" + RequiredHeader);
                    Console.WriteLine("Your header looks like:\n" + headers);
                    return;
                }

                string line;
                while ((line = streamReader.ReadLine()) != null)// && _gillLines.Count < 500)
                {
                    var row = line.Split(',');
                    if(row[(int)GillLine.Column.direction].Equals(Refund) || row[(int)GillLine.Column.payment_status].Equals(Void))
                        _gillLines.Add(new GillLine(row));
                }
            }
        }

        private bool IsHeaderGood(string firstLine) => firstLine.Contains(RequiredHeader);

    }
}