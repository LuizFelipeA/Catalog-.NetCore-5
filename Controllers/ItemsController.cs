using System;
using System.Collections.Generic;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using static Catalog.Entities.item;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return repository.GetItems();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }
            
            return repository.GetItem(id);
        }
    }
}