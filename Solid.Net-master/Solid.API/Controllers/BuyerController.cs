using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerService _buyerservice;

        public BuyerController(IBuyerService buyerService)
        {
            _buyerservice = buyerService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_buyerservice.GetBuyers());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var buyer = _buyerservice.GetById(id);
            if (buyer is null)
            {
                return NotFound();
            }
            return Ok(buyer);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] Buyer value)
        {
            _buyerservice.AddBuyer(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Buyer value)
        {
            _buyerservice.UpdateBuyer(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _buyerservice.DeleteBuyer(id);
           
        }

    }
}
