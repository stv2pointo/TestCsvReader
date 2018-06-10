using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RachelLearnFileRead.Models
{
    public class TransactionsToVoid

    {
        private static string TEMPORARY_PLACE_HOLDER = null;

        public string ProcessCode { get; set; }
        public string DocCode { get; set; }
        public string DocType { get; set; }
        public string DocDate { get; set; }
        public string CompanyCode { get; set; }
        public string CustomerCode { get; set; }
        public string EntityUseCode { get; set; }
        public string LineNo { get; set; }
        public string TaxCode { get; set; }
        public string TaxDate { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Qty { get; set; }
        public string Amount { get; set; }
        public string Discount { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string ExemptionNo { get; set; }
        public string RevAcct { get; set; }
        public string DestAddress { get; set; }
        public string DestCity { get; set; }
        public string DestRegion { get; set; }
        public string DestPostalCode { get; set; }
        public string DestCountry { get; set; }
        public string OrigAddress { get; set; }
        public string OrigCity { get; set; }
        public string OrigRegion { get; set; }
        public string OrigPostalCode { get; set; }
        public string OrigCountry { get; set; }
        public string LocationCode { get; set; }
        public string SalesPersonCode { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string CurrencyCode { get; set; }
        public string ExchangeRate { get; set; }
        public string ExchangeRateEffDate { get; set; }
        public string PaymentDate { get; set; }
        public string TaxIncluded { get; set; }
        public string DestTaxRegion { get; set; }
        public string OrigTaxRegion { get; set; }
        public string Taxable { get; set; }
        public string TaxType { get; set; }
        public string TotalTax { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountryRate { get; set; }
        public string CountryTax { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string StateRate { get; set; }
        public string StateTax { get; set; }
        public string CountyName { get; set; }
        public string CountyCode { get; set; }
        public string CountyRate { get; set; }
        public string CountyTax { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string CityRate { get; set; }
        public string CityTax { get; set; }
        public string Other1Name { get; set; }
        public string Other1Code { get; set; }
        public string Other1Rate { get; set; }
        public string Other1Tax { get; set; }
        public string Other2Name { get; set; }
        public string Other2Code { get; set; }
        public string Other2Rate { get; set; }
        public string Other2Tax { get; set; }
        public string Other3Name { get; set; }
        public string Other3Code { get; set; }
        public string Other3Rate { get; set; }
        public string Other3Tax { get; set; }
        public string Other4Name { get; set; }
        public string Other4Code { get; set; }
        public string Other4Rate { get; set; }
        public string Other4Tax { get; set; }
        public string ReferenceCode { get; set; }
        public string BuyersVATNo { get; set; }
        public string IsSellerImporterOfRecord { get; set; }
        public string BRBuyerType { get; set; }
        public string BRBuyer_IsExemptOrCannotWH_IRRF { get; set; }
        public string BRBuyer_IsExemptOrCannotWH_PISRF { get; set; }
        public string BRBuyer_IsExemptOrCannotWH_COFINSRF { get; set; }
        public string BRBuyer_IsExemptOrCannotWH_CSLLRF { get; set; }
        public string BRBuyer_IsExempt_PIS { get; set; }
        public string BRBuyer_IsExempt_COFINS { get; set; }
        public string BRBuyer_IsExempt_CSLL { get; set; }
        public string Header_Description { get; set; }
        public string Email { get; set; }

        public TransactionsToVoid(AvaleraLine av)
        {
            ProcessCode = "0"; // TODO: CHANGE TO ACTUAL DATA TYPES
            DocCode = av.DocumentCodeValue;
            DocType = "1";
            DocDate = av.DocumentDateValue;
            CompanyCode = "TASK";
            CustomerCode = av.Company;
            EntityUseCode = TEMPORARY_PLACE_HOLDER;
            LineNo = av.LineValue;
            TaxCode = TEMPORARY_PLACE_HOLDER;
            TaxDate = TEMPORARY_PLACE_HOLDER;
            ItemCode = TEMPORARY_PLACE_HOLDER;
            Description = TEMPORARY_PLACE_HOLDER;
            Qty = TEMPORARY_PLACE_HOLDER;
            Amount = av.TotalSalesAmount_Sum;
            Discount = TEMPORARY_PLACE_HOLDER;
            Ref1 = TEMPORARY_PLACE_HOLDER;
            Ref2 = TEMPORARY_PLACE_HOLDER;
            ExemptionNo = TEMPORARY_PLACE_HOLDER;
            RevAcct = TEMPORARY_PLACE_HOLDER;
            DestAddress = TEMPORARY_PLACE_HOLDER;
            DestCity = TEMPORARY_PLACE_HOLDER;
            DestRegion = av.Region; 
            DestPostalCode = TEMPORARY_PLACE_HOLDER;
            DestCountry = TEMPORARY_PLACE_HOLDER;
            OrigAddress                                         = TEMPORARY_PLACE_HOLDER;
            OrigCity                                            = TEMPORARY_PLACE_HOLDER;
            OrigRegion                                          = TEMPORARY_PLACE_HOLDER;
            OrigPostalCode                                      = TEMPORARY_PLACE_HOLDER;
            OrigCountry                                         = TEMPORARY_PLACE_HOLDER;
            LocationCode                                        = TEMPORARY_PLACE_HOLDER;
            SalesPersonCode                                     = TEMPORARY_PLACE_HOLDER;
            PurchaseOrderNo                                     = TEMPORARY_PLACE_HOLDER;
            CurrencyCode                                        = TEMPORARY_PLACE_HOLDER;
            ExchangeRate                                        = TEMPORARY_PLACE_HOLDER;
            ExchangeRateEffDate                                 = TEMPORARY_PLACE_HOLDER;
            PaymentDate                                         = TEMPORARY_PLACE_HOLDER;
            TaxIncluded                                         = TEMPORARY_PLACE_HOLDER;
            DestTaxRegion                                       = TEMPORARY_PLACE_HOLDER;
            OrigTaxRegion                                       = TEMPORARY_PLACE_HOLDER;
            Taxable                                             = TEMPORARY_PLACE_HOLDER;
            TaxType                                             = TEMPORARY_PLACE_HOLDER;
            TotalTax                                            = TEMPORARY_PLACE_HOLDER;
            CountryName                                         = TEMPORARY_PLACE_HOLDER;
            CountryCode                                         = TEMPORARY_PLACE_HOLDER;
            CountryRate                                         = TEMPORARY_PLACE_HOLDER;
            CountryTax                                          = TEMPORARY_PLACE_HOLDER;
            StateName                                           = TEMPORARY_PLACE_HOLDER;
            StateCode                                           = TEMPORARY_PLACE_HOLDER;
            StateRate                                           = TEMPORARY_PLACE_HOLDER;
            StateTax                                            = TEMPORARY_PLACE_HOLDER;
            CountyName                                          = TEMPORARY_PLACE_HOLDER;
            CountyCode                                          = TEMPORARY_PLACE_HOLDER;
            CountyRate                                          = TEMPORARY_PLACE_HOLDER;
            CountyTax                                           = TEMPORARY_PLACE_HOLDER;
            CityName                                            = TEMPORARY_PLACE_HOLDER;
            CityCode                                            = TEMPORARY_PLACE_HOLDER;
            CityRate                                            = TEMPORARY_PLACE_HOLDER;
            CityTax                                             = TEMPORARY_PLACE_HOLDER;
            Other1Name                                          = TEMPORARY_PLACE_HOLDER;
            Other1Code                                          = TEMPORARY_PLACE_HOLDER;
            Other1Rate                                          = TEMPORARY_PLACE_HOLDER;
            Other1Tax                                           = TEMPORARY_PLACE_HOLDER;
            Other2Name                                          = TEMPORARY_PLACE_HOLDER;
            Other2Code                                          = TEMPORARY_PLACE_HOLDER;
            Other2Rate                                          = TEMPORARY_PLACE_HOLDER;
            Other2Tax                                           = TEMPORARY_PLACE_HOLDER;
            Other3Name                                          = TEMPORARY_PLACE_HOLDER;
            Other3Code                                          = TEMPORARY_PLACE_HOLDER;
            Other3Rate                                          = TEMPORARY_PLACE_HOLDER;
            Other3Tax                                           = TEMPORARY_PLACE_HOLDER;
            Other4Name                                          = TEMPORARY_PLACE_HOLDER;
            Other4Code                                          = TEMPORARY_PLACE_HOLDER;
            Other4Rate                                          = TEMPORARY_PLACE_HOLDER;
            Other4Tax                                           = TEMPORARY_PLACE_HOLDER;
            ReferenceCode                                       = TEMPORARY_PLACE_HOLDER;
            BuyersVATNo                                         = TEMPORARY_PLACE_HOLDER;
            IsSellerImporterOfRecord                            = TEMPORARY_PLACE_HOLDER;
            BRBuyerType                                         = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExemptOrCannotWH_IRRF                     = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExemptOrCannotWH_PISRF                    = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExemptOrCannotWH_COFINSRF                 = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExemptOrCannotWH_CSLLRF                   = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExempt_PIS                                = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExempt_COFINS                             = TEMPORARY_PLACE_HOLDER;
            BRBuyer_IsExempt_CSLL                               = TEMPORARY_PLACE_HOLDER;
            Header_Description                                  = TEMPORARY_PLACE_HOLDER;
            Email                                               = TEMPORARY_PLACE_HOLDER;
                                                     
        }

        public enum Column
        {
            ProcessCode
                , DocCode
                , DocType
                , DocDate
                , CompanyCode
                , CustomerCode
                , EntityUseCode
                , LineNo
                , TaxCode
                , TaxDate
                , ItemCode
                , Description
                , Qty
                , Amount
                , Discount
                , Ref1
                , Ref2
                , ExemptionNo
                , RevAcct
                , DestAddress
                , DestCity
                , DestRegion
                , DestPostalCode
                , DestCountry
                , OrigAddress
                , OrigCity
                , OrigRegion
                , OrigPostalCode
                , OrigCountry
                , LocationCode
                , SalesPersonCode
                , PurchaseOrderNo
                , CurrencyCode
                , ExchangeRate
                , ExchangeRateEffDate
                , PaymentDate
                , TaxIncluded
                , DestTaxRegion
                , OrigTaxRegion
                , Taxable
                , TaxType
                , TotalTax
                , CountryName
                , CountryCode
                , CountryRate
                , CountryTax
                , StateName
                , StateCode
                , StateRate
                , StateTax
                , CountyName
                , CountyCode
                , CountyRate
                , CountyTax
                , CityName
                , CityCode
                , CityRate
                , CityTax
                , Other1Name
                , Other1Code
                , Other1Rate
                , Other1Tax
                , Other2Name
                , Other2Code
                , Other2Rate
                , Other2Tax
                , Other3Name
                , Other3Code
                , Other3Rate
                , Other3Tax
                , Other4Name
                , Other4Code
                , Other4Rate
                , Other4Tax
                , ReferenceCode
                , BuyersVATNo
                , IsSellerImporterOfRecord
                , BRBuyerType
                , BRBuyer_IsExemptOrCannotWH_IRRF
                , BRBuyer_IsExemptOrCannotWH_PISRF
                , BRBuyer_IsExemptOrCannotWH_COFINSRF
                , BRBuyer_IsExemptOrCannotWH_CSLLRF
                , BRBuyer_IsExempt_PIS
                , BRBuyer_IsExempt_COFINS
                , BRBuyer_IsExempt_CSLL
                , Header_Description
                , Email
            ,numberofcolumns

        }

        
    }


}
