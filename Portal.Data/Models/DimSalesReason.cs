using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimSalesReason
    {
        public DimSalesReason()
        {
            FactInternetSalesReasons = new HashSet<FactInternetSalesReason>();
        }

        public int SalesReasonKey { get; set; }
        public int SalesReasonAlternateKey { get; set; }
        public string SalesReasonName { get; set; }
        public string SalesReasonReasonType { get; set; }

        public virtual ICollection<FactInternetSalesReason> FactInternetSalesReasons { get; set; }
    }
}
