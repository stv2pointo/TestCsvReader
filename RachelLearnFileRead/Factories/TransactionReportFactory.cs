using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RachelLearnFileRead.Models;

namespace RachelLearnFileRead.Factories
{
    class TransactionReportFactory
    {
        private static string[] transactionStrings;
        private static string path = Constants.DEFAULT_PAYCHECKS_WRITE_PATH;

        public static void Run(string delimiter, TransactionsToVoid[] sortedEntries)
        {
            transactionStrings = new string[sortedEntries.Length + 1];
            var headers = WriteHeaders();
            transactionStrings[0] = headers;
            for (int i = 0; i < sortedEntries.Length; i++)
            {
                TransactionsToVoid e = sortedEntries[i];
                //string text = e.Id;
                //text += delimiter + " " + e.firstName;
                //text += delimiter + " " + e.lastName;
                //text += delimiter + " " + e.getPeriodGrossPay().ToString("F");
                //text += delimiter + " " + e.getFederalTax().ToString("F");
                //text += delimiter + " " + e.getStateTax().ToString("F");
                //text += delimiter + " " + e.getNetPay().ToString("F");
               var text = e.ProcessCode;                                         
               text += delimiter + " " + e.DocCode                                ;
               text += delimiter + " " + e.DocType                                ;
               text += delimiter + " " + e.DocDate                                ;
               text += delimiter + " " + e.CompanyCode                            ;
               text += delimiter + " " + e.CustomerCode                           ;
               text += delimiter + " " + e.EntityUseCode                          ;
               text += delimiter + " " + e.LineNo                                 ;
               text += delimiter + " " + e.TaxCode                                ;
               text += delimiter + " " + e.TaxDate                                ;
               text += delimiter + " " + e.ItemCode                               ;
               text += delimiter + " " + e.Description                            ;
               text += delimiter + " " + e.Qty                                    ;
               text += delimiter + " " + e.Amount                                 ;
               text += delimiter + " " + e.Discount                               ;
               text += delimiter + " " + e.Ref1                                   ;
               text += delimiter + " " + e.Ref2                                   ;
               text += delimiter + " " + e.ExemptionNo                            ;
               text += delimiter + " " + e.RevAcct                                ;
               text += delimiter + " " + e.DestAddress                            ;
               text += delimiter + " " + e.DestCity                               ;
               text += delimiter + " " + e.DestRegion                             ;
               text += delimiter + " " + e.DestPostalCode                         ;
               text += delimiter + " " + e.DestCountry                            ;
               text += delimiter + " " + e.OrigAddress                            ;
               text += delimiter + " " + e.OrigCity                               ;
               text += delimiter + " " + e.OrigRegion                             ;
               text += delimiter + " " + e.OrigPostalCode                         ;
               text += delimiter + " " + e.OrigCountry                            ;
               text += delimiter + " " + e.LocationCode                           ;
               text += delimiter + " " + e.SalesPersonCode                        ;
               text += delimiter + " " + e.PurchaseOrderNo                        ;
               text += delimiter + " " + e.CurrencyCode                           ;
               text += delimiter + " " + e.ExchangeRate                           ;
               text += delimiter + " " + e.ExchangeRateEffDate                    ;
               text += delimiter + " " + e.PaymentDate                            ;
               text += delimiter + " " + e.TaxIncluded                            ;
               text += delimiter + " " + e.DestTaxRegion                          ;
               text += delimiter + " " + e.OrigTaxRegion                          ;
               text += delimiter + " " + e.Taxable                                ;
               text += delimiter + " " + e.TaxType                                ;
               text += delimiter + " " + e.TotalTax                               ;
               text += delimiter + " " + e.CountryName                            ;
               text += delimiter + " " + e.CountryCode                            ;
               text += delimiter + " " + e.CountryRate                            ;
               text += delimiter + " " + e.CountryTax                             ;
               text += delimiter + " " + e.StateName                              ;
               text += delimiter + " " + e.StateCode                              ;
               text += delimiter + " " + e.StateRate                              ;
               text += delimiter + " " + e.StateTax                               ;
               text += delimiter + " " + e.CountyName                             ;
               text += delimiter + " " + e.CountyCode                             ;
               text += delimiter + " " + e.CountyRate                             ;
               text += delimiter + " " + e.CountyTax                              ;
               text += delimiter + " " + e.CityName                               ;
               text += delimiter + " " + e.CityCode                               ;
               text += delimiter + " " + e.CityRate                               ;
               text += delimiter + " " + e.CityTax                                ;
               text += delimiter + " " + e.Other1Name                             ;
               text += delimiter + " " + e.Other1Code                             ;
               text += delimiter + " " + e.Other1Rate                             ;
               text += delimiter + " " + e.Other1Tax                              ;
               text += delimiter + " " + e.Other2Name                             ;
               text += delimiter + " " + e.Other2Code                             ;
               text += delimiter + " " + e.Other2Rate                             ;
               text += delimiter + " " + e.Other2Tax                              ;
               text += delimiter + " " + e.Other3Name                             ;
               text += delimiter + " " + e.Other3Code                             ;
               text += delimiter + " " + e.Other3Rate                             ;
               text += delimiter + " " + e.Other3Tax                              ;
               text += delimiter + " " + e.Other4Name                             ;
               text += delimiter + " " + e.Other4Code                             ;
               text += delimiter + " " + e.Other4Rate                             ;
               text += delimiter + " " + e.Other4Tax                              ;
               text += delimiter + " " + e.ReferenceCode                          ;
               text += delimiter + " " + e.BuyersVATNo                            ;
               text += delimiter + " " + e.IsSellerImporterOfRecord               ;
               text += delimiter + " " + e.BRBuyerType                            ;
               text += delimiter + " " + e.BRBuyer_IsExemptOrCannotWH_IRRF        ;
               text += delimiter + " " + e.BRBuyer_IsExemptOrCannotWH_PISRF       ;
               text += delimiter + " " + e.BRBuyer_IsExemptOrCannotWH_COFINSRF    ;
               text += delimiter + " " + e.BRBuyer_IsExemptOrCannotWH_CSLLRF      ;
               text += delimiter + " " + e.BRBuyer_IsExempt_PIS                   ;
               text += delimiter + " " + e.BRBuyer_IsExempt_COFINS                ;
               text += delimiter + " " + e.BRBuyer_IsExempt_CSLL                  ;
               text += delimiter + " " + e.Header_Description                     ;
                text += delimiter + " " + e.Email;
                transactionStrings[i+1] = text;
            }

            writePaychecksToFile();
        }

        private static string WriteHeaders()
        {
            var delimiter = ",";
            var text = "";
            for (int i = 0; i < (int)TransactionsToVoid.Column.numberofcolumns; i++)
            {
                text +=Enum.GetName(typeof(TransactionsToVoid.Column), i) ;
                text += delimiter;
                
            }

            return text;
        }
        private static void writePaychecksToFile()
        {
            StringArrayToFileWriter.write(path, transactionStrings);
        }

    }

    public class Constants
    {
        //TaxReconcileTestFolderCreation
        //public static string DEFAULT_PAYCHECKS_WRITE_PATH = @"C:/TaxReconcile/Results.csv";
        public static string DEFAULT_PAYCHECKS_WRITE_PATH = @"C:/TaxReconcileTestFolderCreation/Results.csv";
    }
    //public static string GetColumnName(Column column)
    //{
    //var asdf = column.GetType();
    //    return Enum.GetName(typeof(asdf));
    //}


















}