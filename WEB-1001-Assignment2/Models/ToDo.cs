using System.ComponentModel.DataAnnotations;

namespace WEB_1001_Assignment2.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TodoText { get; set; } = "";
        public Boolean Completed { get; set; } = false;
        [DataType(DataType.DateTime)]
        public DateTime? CompletetionDate { get; set; }
    }
}
