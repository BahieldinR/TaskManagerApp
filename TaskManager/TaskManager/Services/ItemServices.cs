using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class ItemServices : IItemServices
    {
        public MainContext _context { get; set; }
        public ItemServices(MainContext context)
        {
            _context = context;
        }

        // adding Item
        public async void add(Item newItem)
        {
            await _context.items.AddAsync(newItem);
            _context.SaveChanges();
        }

        // checks if the item is found in the database to avoid exceptions when deleting any item
        public async Task<bool> IsItemFound(int itemId)
        {
            bool isFound;

            isFound = await _context.items.AnyAsync(item => item.itemId == itemId);

            return isFound;
        }


        // deleting item
        public void DeleteItem(int itemId)
        {
            var itemEntity = _context.items.FirstOrDefault(item => item.itemId == itemId);

            if (itemEntity != null)
            {
                _context.items.Remove(itemEntity);
                _context.SaveChanges();
            }
        }





    }



}
