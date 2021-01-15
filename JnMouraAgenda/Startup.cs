using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JnMouraAgenda.Startup))]
namespace JnMouraAgenda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
