using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services;

namespace WebMVC.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogService _service;
        public CatalogController(ICatalogService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(int page)
        {
            var itemsOnPage = 10;

            var catalog = await _service.GetCatalogItemsAsync(page, itemsOnPage);

            return View(catalog);
        }
    }
}