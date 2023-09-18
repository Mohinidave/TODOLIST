using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Fill the Description !")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the due date ")]
        public DateTime? Duedate { get; set; }

        [Required(ErrorMessage = "Please enter valid category!")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]

        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select Status!")]
        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && Duedate < DateTime.Now;
    }
}
