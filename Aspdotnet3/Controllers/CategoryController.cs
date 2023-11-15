using Aspdotnet3.Data;
using Aspdotnet3.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aspdotnet3.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController(CategoryService service) 
        {
            Service = service;
        }
        public CategoryService Service { get; }
        public async Task<IActionResult> Index()
        {
            List<Models.Category> list = await Service.GetListAsync();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
