using Microsoft.AspNetCore.Mvc;
using Portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AdventureWorksDbContext _db;

        public CustomerController(AdventureWorksDbContext db)
        {
            _db = db;
        }

        [Route("api/customer")]
        public IActionResult Index()
        {
            var customers = _db.DimCustomers.Take(10);

            return Ok(customers);
        }
    }
}
