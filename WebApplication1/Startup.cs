using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VL.Blog.Startup))]
namespace VL.Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
