using System.Web;

namespace nothinbutdotnetstore.web.infrastructure
{
    public class WebFormResponseEngine : ResponseEngine
    {
        ViewFactory view_factory;
        private HttpContext context;
        public WebFormResponseEngine(ViewFactory factory, HttpContext context)
        {
            this.view_factory = factory;
            this.context = context;
        }

        public void prepare<ViewModel>(ViewModel model)
        {

            var handler = view_factory.create_view_for<ViewModel>(model);
            handler.ProcessRequest(context);
        }

        
    }
}