using System.ComponentModel.DataAnnotations;

namespace ToDo_App.Model.DTO
{
    public class TaskDTO
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Starred { get; set; }
        public bool Checked { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        public int ListId { get; set; }
    }
}
