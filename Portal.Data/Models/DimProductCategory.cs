using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimProductCategory
    {
        public DimProductCategory()
        {
            DimProductSubcategories = new HashSet<DimProductSubcategory>();
        }

        public int ProductCategoryKey { get; set; }
        public int? ProductCategoryAlternateKey { get; set; }
        public string EnglishProductCategoryName { get; set; }
        public string SpanishProductCategoryName { get; set; }
        public string FrenchProductCategoryName { get; set; }

        public virtual ICollection<DimProductSubcategory> DimProductSubcategories { get; set; }
    }
}
