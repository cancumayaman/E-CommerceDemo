using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 namespace WebAPI.Controllers
 {
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAllProducts()
        {
            return Ok(_productService.GetAll());
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return Ok();
        }
    }
 }




