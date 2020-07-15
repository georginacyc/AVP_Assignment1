// Name:
// Admin No:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Dazala.Models;
using Dazala.Data;
using Newtonsoft.Json;

namespace Dazala.Controllers {
    public class ProductPOCO {
        public string Name {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}
    }

    [Route("api/product")]
    [ApiController]
    public class ProductAPIController : ControllerBase 
    {
        private readonly DazalaContext _context;

        public ProductAPIController(DazalaContext context) 
        {
            this._context = context;
        }
        // TODO for Part 2
        
        // POST: api/product/new
        [HttpPost("new")]
        public IEnumerable<Product> Post([FromBody] ProductPOCO value) 
        {
            // TODO: Fix me
            var productPOCO = value;
            List<Product> x = this._context.Product
                                            .ToList();
            var product = new Product
                {   
                    Id = x.Count + 1,
                    Name = productPOCO.Name,
                    Description = productPOCO.Description,
                    Price = productPOCO.Price
                };
                this._context.Product.Add(product);
                this._context.SaveChanges();
                List<Product> products = this._context.Product
                                            .Where(p => p.Id == product.Id)
                                            .ToList();
            return products;
        }

        // GET: api/product/all
        [HttpGet("all")] 
        public IEnumerable<Product> Get()
        {
            // TODO: Fix me
            List<Product> products = this._context.Product.ToList(); 
            return products;
        }

        // GET: api/product/get/1
        [HttpGet("get/{id}")]
        public IEnumerable<Product> Get(int id)
        {            
            // TODO: Fix me
            List<Product> products = _context.Product
                                        .Where(p => p.Id == id)
                                        .ToList();
            return products;
        }
    }
}