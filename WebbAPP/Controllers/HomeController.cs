using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using WebbAPP.Helpers.Repositories;
using WebbAPP.Helpers.Services;
using WebbAPP.Models.ViewModels;

namespace WebbAPP.Controllers;

    public class HomeController : Controller
    {

    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    
    public async Task <IActionResult> Index()
        {
        var viewModel = new HomeViewModel
        {
            BestCollection = new CollectionViewModel
            {
                Title = "Best Collection",
                Items = await _productService.GetAllByTagNameAsync("new")
            }
        };


            return View(viewModel);
        }
    }

