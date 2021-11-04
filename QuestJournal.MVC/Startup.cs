using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestJournal.MVC.Startup))]
namespace QuestJournal.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
