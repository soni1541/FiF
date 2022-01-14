using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace game_server_0.EF
{
    public partial class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage="Не указана почта")]
        [Remote(action: "CheckEmail", controller: "User", ErrorMessage = "Email уже используется")]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage="Не указан пароль")]
        [StringLength(60, MinimumLength = 8, ErrorMessage="Пароль должен содержать не меньше 8 символов")]
        public string Password { get; set; } = null!;
        public int Nuts { get; set; }
        public int Level { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
    }
}
