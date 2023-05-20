using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using WebbAPP.Helpers.Services;

namespace WebbAPP.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task  <IActionResult> Details(string articleNumber)
        {
            var item = await _productService.GetAsync(articleNumber);
            return View(item);
        }
    }
}
