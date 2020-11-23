using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimGeography
    {
        public DimGeography()
        {
            DimCustomers = new HashSet<DimCustomer>();
            DimResellers = new HashSet<DimReseller>();
        }

        public int GeographyKey { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public string CountryRegionCode { get; set; }
        public string EnglishCountryRegionName { get; set; }
        public string SpanishCountryRegionName { get; set; }
        public string FrenchCountryRegionName { get; set; }
        public string PostalCode { get; set; }
        public int? SalesTerritoryKey { get; set; }
        public string IpAddressLocator { get; set; }

        public virtual DimSalesTerritory SalesTerritoryKeyNavigation { get; set; }
        public virtual ICollection<DimCustomer> DimCustomers { get; set; }
        public virtual ICollection<DimReseller> DimResellers { get; set; }
    }
}
