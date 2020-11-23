using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class FactSurveyResponse
    {
        public int SurveyResponseKey { get; set; }
        public int DateKey { get; set; }
        public int CustomerKey { get; set; }
        public int ProductCategoryKey { get; set; }
        public string EnglishProductCategoryName { get; set; }
        public int ProductSubcategoryKey { get; set; }
        public string EnglishProductSubcategoryName { get; set; }
        public DateTime? Date { get; set; }

        public virtual DimCustomer CustomerKeyNavigation { get; set; }
        public virtual DimDate DateKeyNavigation { get; set; }
    }
}
