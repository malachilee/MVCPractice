using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCpractice2.Startup))]
namespace MVCpractice2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
