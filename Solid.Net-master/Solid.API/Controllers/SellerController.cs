using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.Service;
using Solid.Core.Entities;
using Solid.API.Models;
using Solid.Core.DTOs;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;
        private readonly IMapper _mapper;

        public SellerController(ISellerService sellerService, IMapper mapper)
        {
            _sellerService = sellerService;
            _mapper= mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            var listD = _sellerService.GetSellers();
            var listDto = _mapper.Map<IEnumerable<SellerDto>>(listD);
            return Ok(listDto);
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
            var sellerDto=_mapper.Map<SellerDto>(seller);   
            return Ok(sellerDto);
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] SellerPostModel value)
        {
            var sell=new Seller { Name = value.Name, Phone=value.Phone};
            _sellerService.AddSeller(sell);
            var sellerDto = _mapper.Map<SellerDto>(sell);
            return Ok(sellerDto);
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
