using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class FactInternetSalesReason
    {
        public string SalesOrderNumber { get; set; }
        public byte SalesOrderLineNumber { get; set; }
        public int SalesReasonKey { get; set; }

        public virtual FactInternetSale SalesOrder { get; set; }
        public virtual DimSalesReason SalesReasonKeyNavigation { get; set; }
    }
}
