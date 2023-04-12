using System.ComponentModel.DataAnnotations;

namespace WEB_1001_Assignment2.Models
{
    //The class for the to do model.
    public class ToDo { 

        //I couldn't think of a better primary key so I had to settle for ID
        [Key]
        public int Id { get; set; }
        //The actual text of the to do itself
        [Required]
        public string TodoText { get; set; } = "";
        //The marker for if the to do is comleted or not.
        public Boolean Completed { get; set; } = false;
        //The date that the to do was complete.  It is optional since its only needed if the to do is completed.
        [DataType(DataType.DateTime)]
        public DateTime? CompletetionDate { get; set; }
    }
}