using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerService _buyerservice;
        private readonly IMapper _mapper;

        public BuyerController(IBuyerService buyerService, IMapper mapper)
        {
            _buyerservice = buyerService;
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            var listD = _buyerservice.GetBuyers();
            var listDto = _mapper.Map<IEnumerable<BuyerDto>>(listD);
            return Ok(listDto);
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
            var buyerDto = _mapper.Map<BuyerDto>(buyer);
            return Ok(buyerDto);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BuyerPostModel value)
        {
            var buy=new Buyer { Name=value.Name, Phone=value.Phone};
            var buyer= await _buyerservice.AddBuyerAsync(buy);
            var buyDto = _mapper.Map<BuyerDto>(buyer);
            return Ok(buyDto);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<Buyer> Put(int id, [FromBody] BuyerPostModel value)
        {
           var buyer=new Buyer { Name=value.Name, Phone=value.Phone};
           return await _buyerservice.UpdateBuyerAsync(id, buyer);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _buyerservice.DeleteBuyerAsync(id);
           
        }

    }
}
