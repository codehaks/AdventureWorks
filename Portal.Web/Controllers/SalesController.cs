using Microsoft.AspNetCore.Mvc;
using Portal.Data;
using Portal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Portal.Web.Controllers
{
    public static class ResellerExtensions
    {
        public static IQueryable<DimReseller> GetLargeResellers(this IQueryable<DimReseller> query)
        {
            return query.Where(r => r.NumberEmployees > 80);
        }
    }
    public class SalesController : Controller
    {
        private readonly AdventureWorksDbContext _db;

        public SalesController(AdventureWorksDbContext db)
        {
            _db = db;
        }

        [Route("api/resellers")]
        public IActionResult GetLargeSellers()
        {
            return Ok(_db.DimResellers
                .Where(CheckLargeReseller)
                .Count());
        }

        [Route("api/resellers/lastorders")]
        public IActionResult GetLargeSellersLastOrders()
        {
            return Ok(_db.DimResellers
                //.Where(IsLargeReseller)
                .GetLargeResellers()
                .Select(r => new
                {
                    r.ResellerName,
                    r.LastOrderYear
                }));
        }

        private Expression<Func<DimReseller, bool>> IsLargeReseller
        {
            get { return r => r.NumberEmployees > 80; }
        }

        private bool CheckLargeReseller(DimReseller reseller)
        {
            return reseller.NumberEmployees > 80;
        }
    }
}
