using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimProductSubcategory
    {
        public DimProductSubcategory()
        {
            DimProducts = new HashSet<DimProduct>();
        }

        public int ProductSubcategoryKey { get; set; }
        public int? ProductSubcategoryAlternateKey { get; set; }
        public string EnglishProductSubcategoryName { get; set; }
        public string SpanishProductSubcategoryName { get; set; }
        public string FrenchProductSubcategoryName { get; set; }
        public int? ProductCategoryKey { get; set; }

        public virtual DimProductCategory ProductCategoryKeyNavigation { get; set; }
        public virtual ICollection<DimProduct> DimProducts { get; set; }
    }
}
