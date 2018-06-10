using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RachelLearnFileRead.Models
{
    public class GillLine
    {
        public string Id { get; set; }
        public string PaymentStatus { get; set; }
        public string Direction { get; set; }

        public GillLine(string[] values)
        {
            Id = "P" + values[(int)Column.payment_id];
            PaymentStatus = values[(int)Column.payment_status];
            Direction = values[(int)Column.direction];
        }

        public enum Column
        {
            doc_code,
            committed_date,
            invoice_creation_date,
            invoice_id,
            invoice_type,
            payment_id,
            payment_status,
            amount,
            direction,
            sales_tax_payment_in_gil,
            sales_tax_line_item_in_gil,
            task_id,
            job_id,
            name,
            state,

        }
    }
}
