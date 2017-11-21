using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(Fima.Web.Startup))]

namespace Fima.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
