using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimPromotion
    {
        public DimPromotion()
        {
            FactInternetSales = new HashSet<FactInternetSale>();
            FactResellerSales = new HashSet<FactResellerSale>();
        }

        public int PromotionKey { get; set; }
        public int? PromotionAlternateKey { get; set; }
        public string EnglishPromotionName { get; set; }
        public string SpanishPromotionName { get; set; }
        public string FrenchPromotionName { get; set; }
        public double? DiscountPct { get; set; }
        public string EnglishPromotionType { get; set; }
        public string SpanishPromotionType { get; set; }
        public string FrenchPromotionType { get; set; }
        public string EnglishPromotionCategory { get; set; }
        public string SpanishPromotionCategory { get; set; }
        public string FrenchPromotionCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MinQty { get; set; }
        public int? MaxQty { get; set; }

        public virtual ICollection<FactInternetSale> FactInternetSales { get; set; }
        public virtual ICollection<FactResellerSale> FactResellerSales { get; set; }
    }
}
