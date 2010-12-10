using System;
using System.Web;

namespace nothinbutdotnetstore.web.infrastructure.webforms
{
    public class WebFormViewFactory : ViewFactory
    {
        private FormFactory form_factory;
        private WebFormRegistry web_form_registry;

        public WebFormViewFactory(FormFactory formFactory, WebFormRegistry webFormRegistry)
        {
            form_factory = formFactory;
            web_form_registry = webFormRegistry;
        }

        public IHttpHandler create_view_for<ViewModel>(ViewModel view_view_model)
        {
            string path = web_form_registry.get_path_to_view_for<ViewModel>();
            ViewFor<ViewModel> view = (ViewFor<ViewModel>)form_factory(path, view_view_model.GetType());
            view.model = view_view_model;
            return view;
        }
    }
}