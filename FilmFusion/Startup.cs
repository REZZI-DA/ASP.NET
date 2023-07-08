using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmFusion.Startup))]
namespace FilmFusion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
