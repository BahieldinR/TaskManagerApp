using TaskManager.Models;

namespace TaskManager.Services
{
    public interface IItemServices
    {
        public void add(Item newItem);
        public Task<bool> IsItemFound(int itemId);
        public void DeleteItem(int itemId);
    }
}
