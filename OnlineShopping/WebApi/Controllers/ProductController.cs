using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
    {
        public static List<ProductInfo> Products { get; private set; }

        static ProductController()
        {
            Products = new List<ProductInfo>
            {
                new ProductInfo{ Id = "1", Name = "Apple iPhone X", Price = 999.00 },
                new ProductInfo{ Id = "2", Name = "Huawei Mat 20 Pro", Price = 936.17 },
                new ProductInfo{ Id = "3", Name = "Honor View 20", Price = 769 },
                new ProductInfo{ Id = "4", Name = "Google Pixel 3 XL", Price = 889.99 },
                new ProductInfo{ Id = "5", Name = "Oneplus 6T", Price = 541.67 },
                new ProductInfo{ Id = "6", Name = "Sony Xperia XZ3", Price = 189.99 },
                new ProductInfo{ Id = "7", Name = "Samsung Galaxy S9", Price = 494.99 },
            };
        }

        // TODO: Get all products
        [HttpGet]
        public IEnumerable<ProductInfo> Get()
        {
            return Products;
        }

        // TODO: Add new product
        [HttpPost]
        public void AddNewProduct([FromBody]ProductInfo product)
        {
            Products.Add(product);
        }

        // TODO: Remove a product by Id
        [HttpDelete("{id}")]
        public void DeleteProduct(string id)
        {
            var deleteProduct = Products.Where(it => it.Id == id).FirstOrDefault();
            if (deleteProduct == null)
            {
                return;
            }
            Products.Remove(deleteProduct);
        }

        // TODO: Update a product
        [HttpPut]
        public void UpdateProduct([FromBody] ProductInfo value)
        {
            var updateProduct = Products.FirstOrDefault(it => it.Id == value.Id);
            if (updateProduct == null)
            {
                return;
            }
            updateProduct.Name = value.Name;
            updateProduct.Price = value.Price;
        }
    }
}