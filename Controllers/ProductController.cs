using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zeus.Models;

namespace Zeus.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;

        }

        [HttpGet("[action]")]
        public Product GetProduct()
        {
            return _context.Products.OrderBy(p => p.Id).First();
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _context.Products.OrderByDescending(p => p.Id).ToList();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }


        // [HttpGet]
        // public IActionResult GetProducts(string search, bool metadata = false)
        // {
        //     IQueryable<Product> query = _context.Products;

        //     if (!string.IsNullOrWhiteSpace(search))
        //     {
        //         string searchLower = search.ToLower();
        //         query = query.Where(m => m.Name.ToLower().Contains(searchLower)
        //         || m.Description.ToLower().Contains(searchLower));
        //     }

        //     return metadata ? CreateMetadata(query) : Ok(query);

        // }
        // private IActionResult CreateMetadata(IEnumerable<Product> products)
        // {
        //     return Ok(new
        //     {
        //         data = products
        //     });
        // }
    }
}
