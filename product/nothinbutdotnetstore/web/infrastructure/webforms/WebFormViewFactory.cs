using System.Web;
using System.Web.Compilation;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.infrastructure.webforms
{
    public class WebFormViewFactory : ViewFactory
    {
        FormFactory form_factory;
        WebFormRegistry web_form_registry;

        public WebFormViewFactory():this(BuildManager.CreateInstanceFromVirtualPath,
            new StubFormViewRegistry())
        {
        }

        public WebFormViewFactory(FormFactory form_factory, WebFormRegistry web_form_registry)
        {
            this.form_factory = form_factory;
            this.web_form_registry = web_form_registry;
        }

        public IHttpHandler create_view_for<ViewModel>(ViewModel view_model)
        {
            var path = web_form_registry.get_path_to_view_for<ViewModel>();
            var view = (ViewFor<ViewModel>) form_factory(path, typeof(ViewFor<ViewModel>));
            view.model = view_model;
            return view;
        }
    }
}