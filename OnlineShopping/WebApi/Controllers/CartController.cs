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
    public class CartController
    {
        public static CartInfo Cart { get; private set; }

        static CartController()
        {
            Cart = new CartInfo
            {
                ProductIds = new List<string>()
            };
        }

        // TODO: Get cart info
        [HttpGet]
        public CartDetail Get()
        {
            var allProducts = ProductController.Products;
            var qry = allProducts.Where(it => Cart.ProductIds.Contains(it.Id)).ToList();
            return new CartDetail
            {
                TotalPrice = Cart.TotalPrice,
                Products = qry,
            };
        }

        // TODO: Add a product to the cart
        [HttpPost]
        public void AddProduct([FromBody]AddProductToCart value)
        {
            var allProduct = ProductController.Products;
            var qry = allProduct.FirstOrDefault(it => it.Id == value.ProductId);
            if (qry == null)
            {
                return;
            }
            Cart.ProductIds.Add(value.ProductId);
            Cart.TotalPrice += qry.Price;

        }
        public class AddProductToCart
        {
            public string ProductId { get; set; }
        }

        // TODO: Remove a product from the cart by product Id
        [HttpDelete("{id}")]
        public void DeleteProduct(string id)
        {
            var allProduct = ProductController.Products;
            var deleteProduct = allProduct.Where(it => it.Id == id).FirstOrDefault();
            if (deleteProduct == null)
            {
                return;
            }
            Cart.ProductIds.Remove(deleteProduct.Id);
            Cart.TotalPrice -= deleteProduct.Price;

        }
    }
}