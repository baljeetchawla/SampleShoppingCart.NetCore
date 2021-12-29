using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingCartSample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProductModels> productInformation;
            using (ShoppingCartSampleContext dbcontext = new ShoppingCartSampleContext())
            {
                productInformation = dbcontext.ProductInformations.Select(x => new ProductModels
                {
                    ProductId = x.ProductId,
                    ProductTitle = x.ProductTitle,
                    Description = x.Description,
                    Price = x.Price.ToString(),
                    ModelNumber = x.ModelNumber
                }).ToList();
            }
            return View(productInformation);
        }
        public IActionResult Checkout()
        {
            List<CartInformationModel> cartInformation;
            using (ShoppingCartSampleContext dbcontext = new ShoppingCartSampleContext())
            {
                cartInformation = dbcontext.CartProductDetails.Select(x => new CartInformationModel
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    productTitle = dbcontext.ProductInformations.Where(p => p.ProductId == x.ProductId).FirstOrDefault().ProductTitle
                }).ToList();
            }
            return View(cartInformation);
        }
        public IActionResult ProductDetails(int id)
        {
            ProductModels productInformation;
            using (ShoppingCartSampleContext dbcontext = new ShoppingCartSampleContext())
            {
                productInformation = dbcontext.ProductInformations.Where(x => x.ProductId == id).Select(x => new ProductModels
                {
                    ProductTitle = x.ProductTitle,
                    Description = x.Description,
                    Price = x.Price.ToString(),
                    ModelNumber = x.ModelNumber,
                    ImageName  = x.ImageName,
                    ProductId = x.ProductId
                }).FirstOrDefault();
            }

            return View(productInformation);
        }
        public string getCartCount(int id)
        {
            int cartCount = 0;
            using (ShoppingCartSampleContext dbcontext = new ShoppingCartSampleContext())
            {
                cartCount = dbcontext.CartProductDetails.Where(x => x.UserId == id).Select(x => x.Quantity).Sum();
            }

            return Json(cartCount).Value.ToString();
        }
        public ContentResult AddToCart(int productId)
        {
            int cartCount = 0;
            using (ShoppingCartSampleContext dbcontext = new ShoppingCartSampleContext())
            {
                CartProductDetail cartinfo;
               
                cartinfo = dbcontext.CartProductDetails.Where(x => x.UserId == 1 && x.ProductId == productId).FirstOrDefault();
                if(cartinfo == null)
                {
                    cartinfo = new CartProductDetail();
                    cartinfo.UserId = 1;
                    cartinfo.ProductId = productId;
                    cartinfo.Quantity = 1;
                    dbcontext.CartProductDetails.Add(cartinfo);
                }
                else
                {
                    cartinfo.Quantity = cartinfo.Quantity + 1;
                }
                dbcontext.SaveChanges();
            }

            return Content(getCartCount(1).ToString());
        }
        public ContentResult DeleteProduct(int productId)
        {
            int cartCount = 0;
            using (ShoppingCartSampleContext dbcontext = new ShoppingCartSampleContext())
            {
                CartProductDetail cartinfo;
                cartinfo = dbcontext.CartProductDetails.Where(x => x.UserId == 1 && x.ProductId == productId).FirstOrDefault();
                if (cartinfo.Quantity == 1)
                {
                    dbcontext.CartProductDetails.Remove(cartinfo);
                }
                else
                {
                    cartinfo.Quantity = cartinfo.Quantity - 1;
                }
                dbcontext.SaveChanges();
            }

            return Content(getCartCount(1).ToString());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
