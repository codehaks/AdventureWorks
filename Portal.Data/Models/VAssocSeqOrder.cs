using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class VAssocSeqOrder
    {
        public string OrderNumber { get; set; }
        public int CustomerKey { get; set; }
        public string Region { get; set; }
        public string IncomeGroup { get; set; }
    }
}
