using System.ComponentModel.DataAnnotations;

namespace Api.DTO
{
    public class UserDto
    {
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage ="Name must be atleast{2}, and maximum{1} characters")]
        public string Name { get; set; }
    }
}
