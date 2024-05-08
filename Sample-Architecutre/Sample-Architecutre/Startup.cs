using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_Architecutre.Startup))]
namespace Sample_Architecutre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
