using TaskManager.Models;

namespace TaskManager.Services
{
    public interface ITaskServices
    {
        public void AddTodoList(TodoList task);
        public Task<bool> IsTodoListFound(string title);
        public void DeleteTodoList(string todoListTitle);
    }
}
