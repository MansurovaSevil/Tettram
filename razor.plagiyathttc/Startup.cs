using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razor.plagiyathttc.Startup))]
namespace razor.plagiyathttc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
