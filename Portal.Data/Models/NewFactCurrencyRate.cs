using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class NewFactCurrencyRate
    {
        public float? AverageRate { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? CurrencyDate { get; set; }
        public float? EndOfDayRate { get; set; }
        public int? CurrencyKey { get; set; }
        public int? DateKey { get; set; }
    }
}
