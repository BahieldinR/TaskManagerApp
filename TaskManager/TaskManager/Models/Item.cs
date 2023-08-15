using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TaskManager.Models
{
    public class Item
    {
        public int itemId { get; set; }

        public int TodoListtaskId { get; set; }

        [Required, MaxLength(800)]
        public string content { get; set; }
    }
}
