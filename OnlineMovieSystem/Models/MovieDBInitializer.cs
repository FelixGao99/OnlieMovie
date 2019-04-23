using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    public class MovieDBInitializer : DropCreateDatabaseAlways<MovieDB>
    {
        protected override void Seed(MovieDB context)
        {
            #region 用户

            User user1 = new User();
            user1.Account = "user1";
            user1.Password = "123123";

            context.Users.Add(user1);

            User user2 = new User();
            user2.Account = "user2";
            user2.Password = "123123";

            context.Users.Add(user2);

            #endregion

            #region 电影分类

            MovieCategory dongzuo = new MovieCategory();
            dongzuo.Name = "动作";

            context.MovieCategories.Add(dongzuo);

            MovieCategory maoxian = new MovieCategory();
            maoxian.Name = "冒险";

            context.MovieCategories.Add(maoxian);

            MovieCategory qihuan = new MovieCategory();
            qihuan.Name = "奇幻";

            context.MovieCategories.Add(qihuan);

            #endregion

            #region 演员

            MovieActor qiaoluosu = new MovieActor();
            qiaoluosu.CnName = "乔·罗素";
            qiaoluosu.EnName = "Joe Russo";
            qiaoluosu.Role = 1;

            context.MovieActors.Add(qiaoluosu);

            MovieActor andongniluosu = new MovieActor();
            andongniluosu.CnName = "安东尼·罗素";
            andongniluosu.EnName = "Anthony Russo";
            andongniluosu.Role = 0;

            context.MovieActors.Add(andongniluosu);

            MovieActor xiaoluobotetangni = new MovieActor();
            xiaoluobotetangni.CnName = "小罗伯特·唐尼";
            xiaoluobotetangni.EnName = "Robert Downey Jr.";
            xiaoluobotetangni.Role = 0;

            context.MovieActors.Add(xiaoluobotetangni);

            MovieActor kelisiaiwensi = new MovieActor();
            kelisiaiwensi.CnName = "克里斯·埃文斯";
            kelisiaiwensi.EnName = "Chris Evans";
            kelisiaiwensi.Role = 0;

            context.MovieActors.Add(kelisiaiwensi);

            #endregion

            #region 电影

            Movie fulian4 = new Movie();
            fulian4.CnName = "复仇者联盟4：终局之战";
            fulian4.EnName = "Avengers: Endgame";
            fulian4.PosterUrl = "/Upload/Images/fulian4.jpg";
            fulian4.ReleaseTime = DateTime.Now;
            fulian4.Description = "改编自漫威漫画，也是漫威电影宇宙第22部影片。复仇者联盟的一众超级英雄，必须抱着牺牲一切的信念，与史上最强大反派灭霸殊死一搏，阻止其摧毁宇宙的邪恶计划。";
            fulian4.MovieLength = 132;
            fulian4.LikeNum = 0;
            fulian4.MovieCategories = new List<MovieCategory>();
            fulian4.MovieCategories.Add(dongzuo);
            fulian4.MovieCategories.Add(maoxian);
            fulian4.MovieCategories.Add(qihuan);
            fulian4.MovieActors = new List<MovieActor>();
            fulian4.MovieActors.Add(qiaoluosu);
            fulian4.MovieActors.Add(andongniluosu);
            fulian4.MovieActors.Add(xiaoluobotetangni);
            fulian4.MovieActors.Add(kelisiaiwensi);

            context.Movies.Add(fulian4);

            #endregion

            base.Seed(context);
        }
    }
}