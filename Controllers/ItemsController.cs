using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;

namespace Catalog.Controllers
{
    //Get/items can olso use "[controller]"
    //to say default will be the name of the controller
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsrepository? repository;

        public ItemsController(IItemsrepository repository)
        { // this is a constructor
            this.repository = repository;
        }

        [HttpGet] // .com/items
        public IEnumerable<Item>? GetItems()
        {
            var items = repository?.GetItems();
            return items;
        }

        [HttpGet("{id}")] // .com/items/id
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository?.GetItem(id);
            if (item is null)
            {
                // return a 404 if item is not found
                return NotFound();
            }
            // if not null return the item
            return item;
        }
    }
}
