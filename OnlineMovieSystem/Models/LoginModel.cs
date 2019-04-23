using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 登录模型
    public class LoginModel
    {
        [Required]
        [Display(Name = "帐号")]
        public string Account { get; set; }

        [Required]
        [Display(Name = "密码")]
        [DataType(DataType.Text)]
        public string Password { get; set; }
    }
}