using System.ComponentModel.DataAnnotations;

namespace BlazorServerDbContextExample.Data
{
    public class Todo
    {
        public int Id { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "First name cannot exceed 100 characters.")]
        public string Desc { get; set; }


        //public bool IsDone { get; set; }
    }
}