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
            List<Product> products = new List<Product>(); 
            return products;
        }

        // GET: api/product/all
        [HttpGet("all")] 
        public IEnumerable<Product> Get()
        {
            // TODO: Fix me
            List<Product> products = new List<Product>(); 
            return products;
        }

        // GET: api/product/get/1
        [HttpGet("get/{id}")]
        public IEnumerable<Product> Get(int id)
        {            
            // TODO: Fix me
            List<Product> products = new List<Product>(); 
            return products;
        }
    }
}