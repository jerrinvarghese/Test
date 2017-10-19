using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAddDynamicTextBox.Startup))]
namespace MVCAddDynamicTextBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
