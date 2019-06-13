using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoardCafeServer.Objects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoardCafeServer.Areas.BoardCafeAreas.Service;

namespace BoardCafeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeMenuItemController : ControllerBase
    {
        // GET: api/CafeMenuItem
        [HttpGet]
        public IEnumerable<CafeMenuItem> Get()
        {
            CafeMenuItem item1 = new CafeMenuItem();

            item1.itemId = 1;
            item1.itemName = "New Item";
            item1.itemDesc = "This is a new Item";
            item1.itemPrice = 12.99;
            item1.peanut = false;
            item1.shellfish = false;
            item1.gluten = false;
        
            return new CafeMenuItem[] {item1 };
        }

        [HttpGet("getAllItems")]
        public List<CafeMenuItem> getAllCafeMenuItems()
        {
            CafeMenuItemService service = new CafeMenuItemServiceImpl();
            List<CafeMenuItem> cafeMenuItems = service.getAllCafeMenuItem();
            return cafeMenuItems;
        }

        // GET: api/CafeMenuItem/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(string id)
        {
            return id;
        }

        // POST: api/CafeMenuItem
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/CafeMenuItem/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
