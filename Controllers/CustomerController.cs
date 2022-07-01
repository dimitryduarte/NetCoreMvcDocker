using webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    public class CustomerController :Controller
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Customers.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(string.Empty, 
                       $"Algo deu errado {ex.Message}");
                }
            }
            ModelState.AddModelError(string.Empty, 
               $"Algo deu errado, modelo inválido");
            return View(customer);
        }        
    }
}