using System.Web;

namespace nothinbutdotnetstore.web.infrastructure
{
    public interface ViewFor<ViewModel> : IHttpHandler
    {
        ViewModel model { get; set; } 
    }
}