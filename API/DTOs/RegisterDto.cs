using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; }
        [Required] public string KnownAs { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public DateTime BirthDate { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Country { get; set; }
        [Required] [StringLength(16, MinimumLength = 8)] public string Password { get; set; }
    }
}