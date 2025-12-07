using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Store.Service;

namespace Store.Controllers
{
  
[ApiController]
    [Route("cart")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;

        public CartController(ICartService service)
        {
            _service = service;
        }

        // POST /cart
        [HttpPost]
        
        public IActionResult AddToCart([FromBody] List<CartItem> items)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            foreach (var item in items)
            {
                _service.AddToCart(item);
            }

            return Ok(_service.GetCart());
        }

        // PATCH /cart
        [HttpPatch]
        public IActionResult UpdateCart([FromBody] CartItem item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _service.UpdateCart(item);
            return Ok(_service.GetCart());
        }
    }

}
