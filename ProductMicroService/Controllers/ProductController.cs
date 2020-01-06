using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Data.Interface;
using ProductMicroservice.Data.Models;

namespace ProductMicroService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
         private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        // GET: api/GetAllProduct
        [HttpGet]
        [ActionName("GetAllProduct")]
        [Route("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            try
            {
                var products = _productRepository.GetProducts();
                if (products == null)
                {
                    return new NotFoundObjectResult(products);
                }

                return new OkObjectResult(products);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);

            }

        }

        [HttpGet]
        [ActionName("GetProductById")]
        [Route("GetProductById")]
        public IActionResult GetProductById(int id)
        {
            try
            {

                var product = _productRepository.GetProductById(id);
                if (product == null)
                {
                    return new NotFoundObjectResult(product);
                }

                return new OkObjectResult(product);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);


            }

        }

        [HttpPost]
        [ActionName("AddProduct")]
        [Route("AddProduct")]
        public IActionResult AddProduct(Products products)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return new BadRequestObjectResult(products);
                }
                int id = _productRepository.InsertProduct(products);
                return new OkObjectResult(id);

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdateProduct")]
        [Route("UpdateProduct/")]
        public IActionResult UpdateProduct(Products Product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return new BadRequestObjectResult(Product);
                }
                int id = _productRepository.UpdateProduct(Product);
                return new OkObjectResult(id);

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpGet]
        [ActionName("DeleteProduct")]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {

                var Product = _productRepository.DeleteProduct(id);

                return new OkObjectResult(Product);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);


            }

        }
    }
}
