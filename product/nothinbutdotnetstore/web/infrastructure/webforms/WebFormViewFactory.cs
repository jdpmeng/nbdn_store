using System;
using System.Web;

namespace nothinbutdotnetstore.web.infrastructure.webforms
{
    public class WebFormViewFactory : ViewFactory
    {
        public IHttpHandler create_view_for<ViewModel>(ViewModel view_view_model)
        {
            throw new NotImplementedException();
        }
    }
}