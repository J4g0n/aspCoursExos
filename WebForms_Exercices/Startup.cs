using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms_Exercices.Startup))]
namespace WebForms_Exercices
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
