using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 电影分类
    public class MovieCategory
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "分类名称")]
        public string Name { get; set; }
    }
}