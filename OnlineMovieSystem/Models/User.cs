using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 用户
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "帐号")]
        public string Account { get; set; }

        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "昵称")]
        public string Name { get; set; }

        public List<Movie> LikedMovie { get; set; }  // 收藏的电影

        public List<MovieComment> MovieComments { get; set; }  // 用户评论
    }
}