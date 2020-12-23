using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly AdventureWorksDbContext _db;

        public ReportController(AdventureWorksDbContext db)
        {
            _db = db;
        }

        [Route("sales/territory")]
        public IActionResult Index()
        {
            //var q = _db.FactResellerSales
            //    .Include(f => f.SalesTerritoryKeyNavigation)
            //    .Take(10).Select(f => new { f.SalesAmount, f.SalesTerritoryKeyNavigation.SalesTerritoryCountry });
            //var l = q.ToList();

            //var q1 = _db.FactResellerSales.Join(_db.DimSalesTerritories,
            //    f => f.SalesTerritoryKey,
            //    t => t.SalesTerritoryKey,

            //    (f, t) => new
            //    {
            //        Sales = f,
            //        Ter = t
            //    }).Select(q =>
            //    new
            //    {
            //        q.Sales.SalesAmount,
            //        q.Ter.SalesTerritoryCountry
            //    })
            //    .Take(10);

            //var l1 = q1.ToList();

            var q2 = from Sales in _db.FactResellerSales
                     join Ter in _db.DimSalesTerritories
                     on Sales.SalesTerritoryKey equals Ter.SalesTerritoryKey

                     join Product in _db.DimProducts
                     on Sales.ProductKey equals Product.ProductKey

                     select new
                     {
                         Sales.SalesAmount,
                         Product.ModelName,
                         Ter.SalesTerritoryCountry
                     };

            return Ok(q2.Take(10).ToList());
        }

        [Route("sales/territory/raw/{geo}/{count}")]
        public IActionResult GetTerritory(int geo,int count)
        {
            var q = _db.DimCustomers
                .FromSqlRaw("SELECT TOP ({1}) * FROM DimCustomer WHERE GeographyKey={0}",geo,count)
                .Select(t => new { t.FirstName, t.LastName,t.GeographyKey });
            return Ok(q.ToList());
        }

    }
}
