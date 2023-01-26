using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcToDoList.Models
{
    public class ToDoList
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string? Task { get; set; }

        [StringLength(150)]
        public string? Description { get; set; }
        public string? Status { get; set; }

        [NotMapped]
        public List<SelectListItem> StatusList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "To do", Text = "To do" },
            new SelectListItem { Value = "Planning", Text = "Planning" },
            new SelectListItem { Value = "In progress", Text = "In progress" },
            new SelectListItem { Value = "Waiting for support", Text = "Waiting for support" },
            new SelectListItem { Value = "Done", Text = "Done" },
            
        };

        [StringLength(250)]
        public string? Comments { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime CompleteBy { get; set; } = DateTime.Now.AddDays(1);
    }
}