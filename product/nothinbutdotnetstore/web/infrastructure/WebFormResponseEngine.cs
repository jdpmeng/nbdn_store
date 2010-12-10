using System;

namespace nothinbutdotnetstore.web.infrastructure
{
    public class WebFormResponseEngine : ResponseEngine
    {
        private ViewFactory viewFactory;

        public WebFormResponseEngine(ViewFactory factory)
        {
            this.viewFactory = factory;
        }

        public void prepare<ViewModel>(ViewModel model)
        {
            viewFactory.create_view_for(model);
        }
    }
}