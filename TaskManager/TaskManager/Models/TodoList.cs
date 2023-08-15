using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TodoList
    {
        [Key]
        public int taskId { get; set; }

        
        public DateTime creationDate { get; set; }


        [Required, MaxLength(300)]
        public string title { get; set; }


        public List<Item> items { get; set; }

    }
}
