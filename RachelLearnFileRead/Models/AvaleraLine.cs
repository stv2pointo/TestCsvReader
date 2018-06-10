using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RachelLearnFileRead.Models
{
    public class AvaleraLine
    {
        public string Company { get; set; }
        public string DocumentCodeValue { get; set; }
        public string DocumentDateValue { get; set; }
        public string Region_1 { get; set; }
        public string TotalSalesAmount_Sum { get; set; }
        public string TotalDiscountAmount_Sum { get; set; }
        public string TotalExempt_Sum { get; set; }
        public string TaxableSales_Sum { get; set; }
        public string TotalSalesTaxAmount_Sum { get; set; }
        public string Region { get; set; }
        public string LineValue { get; set; }
        public string ItemValue { get; set; }
        public string TaxCodeValue { get; set; }
        public string QuantityValue { get; set; }
        public string LineAmountValue { get; set; }
        public string DiscountAmountValue { get; set; }
        public string ExemptAmountValue { get; set; }
        public string TaxableAmountValue { get; set; }
        public string TaxValue { get; set; }
        public string CompanyTotal_TotalSalesAmount { get; set; }
        public string CompanyTotal_TotalDiscountAmount { get; set; }
        public string CompanyTotal_TotalExempt { get; set; }
        public string CompanyTotal_TaxableSales { get; set; }
        public string CompanyTotal_TotalSalesTaxAmount { get; set; }
        public string GrandTotal_TotalAmount { get; set; }
        public string GrandTotal_DiscountAmount { get; set; }
        public string GrandTotal_TotalExempt { get; set; }
        public string GrandTotal_TotalTaxable { get; set; }
        public string GrandTotal_TotalTax { get; set; }

        public AvaleraLine(string[] values)
        {
            Company = values[(int)Column.Company];
            DocumentCodeValue = values[(int)Column.DocumentCodeValue];
            DocumentDateValue = values[(int)Column.DocumentDateValue];
            Region_1 = values[(int)Column.Region_1];
            TotalSalesAmount_Sum = values[(int)Column.TotalSalesAmount_Sum];
            TotalDiscountAmount_Sum = values[(int)Column.TotalDiscountAmount_Sum];
            TotalExempt_Sum = values[(int)Column.TotalExempt_Sum];
            TaxableSales_Sum = values[(int)Column.TaxableSales_Sum];
            TotalSalesTaxAmount_Sum = values[(int)Column.TotalSalesTaxAmount_Sum];
            Region = values[(int)Column.Region];
            LineValue = values[(int)Column.LineValue];
            ItemValue = values[(int)Column.ItemValue];
            TaxCodeValue = values[(int)Column.TaxCodeValue];
            QuantityValue = values[(int)Column.QuantityValue];
            LineAmountValue = values[(int)Column.LineAmountValue];
            DiscountAmountValue = values[(int)Column.DiscountAmountValue];
            ExemptAmountValue = values[(int)Column.ExemptAmountValue];
            TaxableAmountValue = values[(int)Column.TaxableAmountValue];
            TaxValue = values[(int)Column.TaxValue];
            CompanyTotal_TotalSalesAmount = values[(int)Column.CompanyTotal_TotalSalesAmount];
            CompanyTotal_TotalDiscountAmount = values[(int)Column.CompanyTotal_TotalDiscountAmount];
            CompanyTotal_TotalExempt = values[(int)Column.CompanyTotal_TotalExempt];
            CompanyTotal_TaxableSales = values[(int)Column.CompanyTotal_TaxableSales];
            CompanyTotal_TotalSalesTaxAmount = values[(int)Column.CompanyTotal_TotalSalesTaxAmount];
            GrandTotal_TotalAmount = values[(int)Column.GrandTotal_TotalAmount];
            GrandTotal_DiscountAmount = values[(int)Column.GrandTotal_DiscountAmount];
            GrandTotal_TotalExempt = values[(int)Column.GrandTotal_TotalExempt];
            GrandTotal_TotalTaxable = values[(int)Column.GrandTotal_TotalTaxable];
            GrandTotal_TotalTax = values[(int)Column.GrandTotal_TotalTax];

        }



        private enum Column
        {
            Company
            , DocumentCodeValue
            , DocumentDateValue
            , Region_1
            , TotalSalesAmount_Sum
            , TotalDiscountAmount_Sum
            , TotalExempt_Sum
            , TaxableSales_Sum
            , TotalSalesTaxAmount_Sum
            , Region
            , LineValue
            , ItemValue
            , TaxCodeValue
            , QuantityValue
            , LineAmountValue
            , DiscountAmountValue
            , ExemptAmountValue
            , TaxableAmountValue
            , TaxValue
            , CompanyTotal_TotalSalesAmount
            , CompanyTotal_TotalDiscountAmount
            , CompanyTotal_TotalExempt
            , CompanyTotal_TaxableSales
            , CompanyTotal_TotalSalesTaxAmount
            , GrandTotal_TotalAmount
            , GrandTotal_DiscountAmount
            , GrandTotal_TotalExempt
            , GrandTotal_TotalTaxable
            , GrandTotal_TotalTax

        }
    }
}
