using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_4.Startup))]
namespace Lab_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
