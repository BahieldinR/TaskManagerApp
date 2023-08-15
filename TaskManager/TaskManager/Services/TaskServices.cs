using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskServices : ITaskServices
    {
        public MainContext _context { get; set; }
        public TaskServices(MainContext context)
        {
            _context = context;
        }

        // adding todoList
        public async void AddTodoList(TodoList todoList)
        {
            await _context.tasks.AddAsync(todoList);
            _context.SaveChanges();
        }

        // checks if the todoList is found in the database to avoid exceptions when deleting any todoList
        public async Task<bool> IsTodoListFound(string title)
        {
            bool isFound;

            isFound = await _context.tasks.AnyAsync(a => a.title == title); ;

            if (isFound)
            {
                return true;
            }
            return false;
        }


        // deleting todoList
        public void DeleteTodoList(string todoListTitle)
        {
            var todoListEntity = _context.tasks.FirstOrDefault(c => c.title == todoListTitle);
    
            _context.tasks.Remove(todoListEntity);
            
            _context.SaveChanges();
        }






    }



}
