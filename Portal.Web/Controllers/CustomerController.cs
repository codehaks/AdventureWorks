using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portal.Data;
using Portal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Controllers
{
    public class CustomerData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
    public class CustomerController : Controller
    {
        private readonly AdventureWorksDbContext _db;
        private readonly ILogger _logger;
        public CustomerController(AdventureWorksDbContext db, ILogger<CustomerController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [Route("api/customer/take")]
        public IActionResult GetTake()
        {
            var customer = _db.DimCustomers
                .OrderBy(c => c.BirthDate)
                .Skip(20)
                .Take(10);
            return Ok(customer);
        }

        [Route("api/customer/sale")]
        public IActionResult GetSale()
        {
            //var customer = _db
            //    .DimCustomers
            //    .Where(c => c.BirthDate.HasValue && c.BirthDate.Value.Year == 1950)
            //    .Count();
            List<int> number = new List<int>() { 10, 20 };
            List<DimCustomer> customers = new();
            var sales = _db.FactInternetSales
                .SelectMany(s => customers,
                (f, c) => new { f.SalesAmount }
              );

            return Ok(sales);
        }

        [Route("api/customer/last")]
        public IActionResult Get(int id)
        {
            var customer = _db.DimCustomers
                .OrderByDescending(c => c.BirthDate)
                .Last(c => c.FirstName == "David");

            return Ok(customer);
        }

        [Route("api/customer")]
        public IActionResult Get()
        {
            var q1 = _db.DimCustomers
                .Select(c => new CustomerData
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    EmailAddress = c.EmailAddress
                })
                .Take(100);

            var q2 = q1.Where(c => c.FirstName.StartsWith("A"));

            var q3 = q2.Where(c => c.LastName.StartsWith("B"));

            return Ok(q3);
        }

        [Route("customers")]
        public IActionResult Index()
        {
            var q1 = _db.DimCustomers
                .Select(c => new CustomerData
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    EmailAddress = c.EmailAddress
                })
                .Take(100);

            var q2 = q1.Where(c => c.FirstName.StartsWith("A"));

            var q3 = q2.Where(c => c.LastName.StartsWith("B"))
                .ToList();

            return View(q3);
        }
    }
}

