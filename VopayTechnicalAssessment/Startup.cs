using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VopayTechnicalAssessment.Startup))]
namespace VopayTechnicalAssessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
