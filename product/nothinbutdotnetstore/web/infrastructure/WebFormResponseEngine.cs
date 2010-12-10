namespace nothinbutdotnetstore.web.infrastructure
{
    public class WebFormResponseEngine : ResponseEngine
    {
        ViewFactory view_factory;

        public WebFormResponseEngine(ViewFactory factory)
        {
            this.view_factory = factory;
        }

        public void prepare<ViewModel>(ViewModel model)
        {
            view_factory.create_view_for(model);
        }
    }
}