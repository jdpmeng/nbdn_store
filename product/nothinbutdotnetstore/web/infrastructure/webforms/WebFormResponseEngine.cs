namespace nothinbutdotnetstore.web.infrastructure.webforms
{
    public class WebFormResponseEngine : ResponseEngine
    {
        ViewFactory view_factory;
        ContextResolver context_resolver;

        public WebFormResponseEngine(ViewFactory factory, ContextResolver context_resolver)
        {
            this.view_factory = factory;
            this.context_resolver = context_resolver;
        }

        public void prepare<ViewModel>(ViewModel model)
        {
            var handler = view_factory.create_view_for(model);
            handler.ProcessRequest(context_resolver());
        }
    }
}