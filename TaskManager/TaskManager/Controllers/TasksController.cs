using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("/TodoList")]
    public class TasksController : ControllerBase
    {
        public ITaskServices _taskServices;
        public TasksController(ITaskServices taskServices)
        {
            _taskServices = taskServices;
        }

        // adding todoList, using Modelstate to validate the user input
        [HttpPost]
        public async Task<IActionResult> AddTodoList([FromBody] TodoList todoList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TodoList newList = new TodoList
            {
                title = todoList.title,
                creationDate = DateTime.Now
            };


            _taskServices.AddTodoList(newList);

            return Created(todoList.title,"Created Successfully");
        }

        // deleting todoList, return bad request if the list is not found in the database to handle the resource not found exception
        [HttpDelete]
        public async Task<IActionResult> DeleteTodoList([FromBody] string title)
        {
            bool IstodoListFound = await _taskServices.IsTodoListFound(title);

            if (IstodoListFound == true)
            {
                _taskServices.DeleteTodoList(title);
                return NoContent();
            }

            return NotFound($"Can't find todoList : {title}");
        }


    }
}
