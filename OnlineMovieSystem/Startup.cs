using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineMovieSystem.Startup))]
namespace OnlineMovieSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
