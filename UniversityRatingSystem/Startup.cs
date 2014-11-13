using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityRatingSystem.Startup))]
namespace UniversityRatingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
