using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class FactSalesQuotum
    {
        public int SalesQuotaKey { get; set; }
        public int EmployeeKey { get; set; }
        public int DateKey { get; set; }
        public short CalendarYear { get; set; }
        public byte CalendarQuarter { get; set; }
        public decimal SalesAmountQuota { get; set; }
        public DateTime? Date { get; set; }

        public virtual DimDate DateKeyNavigation { get; set; }
        public virtual DimEmployee EmployeeKeyNavigation { get; set; }
    }
}
