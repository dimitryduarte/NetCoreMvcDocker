using webapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class CustomerApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly string ClientID;
        private readonly string ClientSecret;

        public CustomerApiController(AppDbContext context)
        {
            _context = context;
            ClientID = "12345";
            ClientSecret = "1234567";
        }

        [HttpGet]
        [Route("login")]
        public ActionResult Login(LoginRequestDTO loginRequest)
        {

            var customers = _context.Customers.ToList();
            return Ok(customers);
        }        

        [HttpGet]
        [Route("customers")]
        public ActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList();
            return Ok(customers);
        }

        // [HttpPost]
        // [Route("customers")]        
        // public async Task<IActionResult> Create(Customer customer)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Customers.Add(customer);
        //             await _context.SaveChangesAsync();
        //             return RedirectToAction("Index");
        //         }
        //         catch(Exception ex)
        //         {
        //             ModelState.AddModelError(string.Empty, 
        //                $"Algo deu errado {ex.Message}");
        //         }
        //     }
        //     ModelState.AddModelError(string.Empty, 
        //        $"Algo deu errado, modelo inválido");
        //     return Ok(customer);
        // }        
    }
}