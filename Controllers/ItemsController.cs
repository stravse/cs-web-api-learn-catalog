using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;

namespace Catalog.Controllers
{
    //Get/items can olso use "[controller]" 
    //to say default will be the name of the controller
    [ApiController]
    [Route("items")]
    public class ItemsController: ControllerBase
    {
        private readonly InMemItemsRepository? repository;

        public ItemsController(){
            repository = new InMemItemsRepository();
        }
        [HttpGet]
        public IEnumerable<Item>? GetItems(){
            var items = repository?.GetItems();
            return items;
        }
    }
}