using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 电影
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name="电影名称（中文）")]
        public string CnName { get; set; }

        [Display(Name = "电影名称（英文）")]
        public string EnName { get; set; }

        [Display(Name = "电影海报Url")]
        public string PosterUrl { get; set; }

        [Display(Name = "上映时间")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseTime { get; set; }

        [Display(Name = "电影时长")]
        public int? MovieLength { get; set; }

        [Display(Name = "剧情简介")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "点赞量")]
        public int? LikeNum { get; set; }


        public virtual List<MovieCategory> MovieCategories { get; set; }  // 电影分类

        public virtual List<MovieActor> MovieActors { get; set; }  // 演员

        public virtual List<MovieComment> MovieComments { get; set; }  // 电影评论
    }
}