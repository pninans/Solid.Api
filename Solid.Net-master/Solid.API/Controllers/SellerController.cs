using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.Service;
using Solid.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;

        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sellerService.GetSellers());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var seller = _sellerService.GetById(id);
            if (seller is null)
            {
                return NotFound();
            }
            return Ok(seller);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] Seller value)
        {
            _sellerService.AddSeller(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Seller value)
        {
            _sellerService.UpdateSeller(id, value); 
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _sellerService.DeleteSeller(id);
        }
    }
}
