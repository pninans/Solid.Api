using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.Service;
using Solid.Core.Entities;
using Solid.API.Models;
using Solid.Core.DTOs;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            var listD = _productService.GetProducts();
            var listDto = _mapper.Map<IEnumerable<BuyerDto>>(listD);
            return Ok(listDto);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetById(id);
            if (product is null)
            {
                return NotFound();
            }
            var productDto=_mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductPostModel value)
        {
            var pro = new Product { Name = value.Name, Price = value.Price, SellerId = value.SellerId, Status = value.Status };
            _productService.AddProduct(pro);
            var proDto = _mapper.Map<ProductDto>(pro);
            return Ok(proDto);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _productService.UpdateProduct(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
