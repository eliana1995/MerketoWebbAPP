using Microsoft.AspNetCore.Mvc;
using WebbAPP.Helpers.Repositories;
using WebbAPP.Models.ViewModels;

namespace WebbAPP.Controllers;

    public class ContactsController : Controller
    {

    private readonly ContactFormRepo _contactFormRepo;

    public ContactsController(ContactFormRepo contactFormRepo)
    {
        _contactFormRepo = contactFormRepo;
    }

    public IActionResult Index()
        {
            return View();
        }

    [HttpPost]
    public async Task <IActionResult> Index(ContactFormViewModel viewModel)
    {

        if (ModelState.IsValid)
        {
            await _contactFormRepo.AddAsync(new Models.Entities.ContactFormEntity
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Massage = viewModel.Massage,
            });

            return RedirectToAction("Index");
        }
            return View(viewModel);
    }





}

