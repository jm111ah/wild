using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wild.Models
{
    public class User
    {
        [Required(ErrorMessage = "Email을 입력해주세요.")]
        [MaxLength(10)]
        public string Email { get; set; }
        [Required(ErrorMessage = "비밀번호를 입력해주세요.")]
        [MinLength(3)]
        public string Pass { get; set; }
    }
}
