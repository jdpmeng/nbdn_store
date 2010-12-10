using System.Web;

namespace nothinbutdotnetstore.web.infrastructure
{
    public interface ViewFactory
    {
        IHttpHandler create_view_for<ViewModel>(ViewModel view_view_model);
    }
}