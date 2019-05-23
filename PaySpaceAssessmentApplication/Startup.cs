using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaySpaceAssessmentApplication.Startup))]
namespace PaySpaceAssessmentApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
