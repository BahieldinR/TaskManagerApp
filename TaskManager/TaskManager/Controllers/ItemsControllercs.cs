using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("/Items")]
    public class ItemsController : ControllerBase
    {
        public IItemServices _ItemServices;
        public ItemsController(IItemServices ItemServices)
        {
            _ItemServices = ItemServices;
        }

        // adding Item, using Modelstate to validate the user input
        [HttpPost]
        public async Task<IActionResult> AddItem([FromBody] Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Item newItem = new Item
            {
                TodoListtaskId = item.TodoListtaskId,
                content = item.content,
            };

            _ItemServices.add(newItem);

            return Ok();
        }

        // deleting item, return bad request if the item is not found in the database to handle the resource not found exception
        [HttpDelete]
        public async Task<IActionResult> DeleteItem([FromBody] int itemId)
        {
            bool IsItemFound = await _ItemServices.IsItemFound(itemId);

            if (IsItemFound == true)
            {
                _ItemServices.DeleteItem(itemId);
                return NoContent();
            }

            return NotFound($"Can't find Item : {itemId}");
        }


    }
}
