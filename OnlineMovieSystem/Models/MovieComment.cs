using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 电影评论
    public class MovieComment
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "评论日期")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "评论内容")]
        public string Content { get; set; }

        [Display(Name = "评论星级")]
        public int? Level { get; set; }

        [Display(Name = "评论点赞量")]
        public int? LikeNum { get; set; }

        [Display(Name = "评论用户ID")]
        [ScaffoldColumn(false)]
        public int userId { get; set; }

        [Display(Name = "评论电影ID")]
        [ScaffoldColumn(false)]
        public int movieId { get; set; }


        public virtual Movie movie { get; set; }
        public virtual User user { get; set; }
    }
}