using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimDate
    {
        public DimDate()
        {
            FactCallCenters = new HashSet<FactCallCenter>();
            FactCurrencyRates = new HashSet<FactCurrencyRate>();
            FactInternetSaleDueDateKeyNavigations = new HashSet<FactInternetSale>();
            FactInternetSaleOrderDateKeyNavigations = new HashSet<FactInternetSale>();
            FactInternetSaleShipDateKeyNavigations = new HashSet<FactInternetSale>();
            FactProductInventories = new HashSet<FactProductInventory>();
            FactResellerSaleDueDateKeyNavigations = new HashSet<FactResellerSale>();
            FactResellerSaleOrderDateKeyNavigations = new HashSet<FactResellerSale>();
            FactResellerSaleShipDateKeyNavigations = new HashSet<FactResellerSale>();
            FactSalesQuota = new HashSet<FactSalesQuotum>();
            FactSurveyResponses = new HashSet<FactSurveyResponse>();
        }

        public int DateKey { get; set; }
        public DateTime FullDateAlternateKey { get; set; }
        public byte DayNumberOfWeek { get; set; }
        public string EnglishDayNameOfWeek { get; set; }
        public string SpanishDayNameOfWeek { get; set; }
        public string FrenchDayNameOfWeek { get; set; }
        public byte DayNumberOfMonth { get; set; }
        public short DayNumberOfYear { get; set; }
        public byte WeekNumberOfYear { get; set; }
        public string EnglishMonthName { get; set; }
        public string SpanishMonthName { get; set; }
        public string FrenchMonthName { get; set; }
        public byte MonthNumberOfYear { get; set; }
        public byte CalendarQuarter { get; set; }
        public short CalendarYear { get; set; }
        public byte CalendarSemester { get; set; }
        public byte FiscalQuarter { get; set; }
        public short FiscalYear { get; set; }
        public byte FiscalSemester { get; set; }

        public virtual ICollection<FactCallCenter> FactCallCenters { get; set; }
        public virtual ICollection<FactCurrencyRate> FactCurrencyRates { get; set; }
        public virtual ICollection<FactInternetSale> FactInternetSaleDueDateKeyNavigations { get; set; }
        public virtual ICollection<FactInternetSale> FactInternetSaleOrderDateKeyNavigations { get; set; }
        public virtual ICollection<FactInternetSale> FactInternetSaleShipDateKeyNavigations { get; set; }
        public virtual ICollection<FactProductInventory> FactProductInventories { get; set; }
        public virtual ICollection<FactResellerSale> FactResellerSaleDueDateKeyNavigations { get; set; }
        public virtual ICollection<FactResellerSale> FactResellerSaleOrderDateKeyNavigations { get; set; }
        public virtual ICollection<FactResellerSale> FactResellerSaleShipDateKeyNavigations { get; set; }
        public virtual ICollection<FactSalesQuotum> FactSalesQuota { get; set; }
        public virtual ICollection<FactSurveyResponse> FactSurveyResponses { get; set; }
    }
}
