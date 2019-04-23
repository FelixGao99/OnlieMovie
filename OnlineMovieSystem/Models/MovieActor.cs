using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 演员
    public class MovieActor
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "中文名")]
        public string CnName { get; set; }

        [Display(Name = "英文名")]
        public string EnName { get; set; }

        [Display(Name = "类型")]
        public int Role { get; set; }  // 0 - 演员  1 - 导演

    }
}