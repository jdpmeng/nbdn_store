using System;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class View<ViewModel> : ApplicationCommand
    {
        StoreDirectory store_directory;
        ResponseEngine response_engine;
        private Func<Request, StoreDirectory, ViewModel> get_view_model;

        public View():this(new StubStoreDirectory(),
            new StubResponseEngine(), (x, y) => default(ViewModel))
        {
        }

        public View(StoreDirectory store_directory, ResponseEngine response_engine, Func<Request, StoreDirectory, ViewModel> get_view_model)
        {
            this.store_directory = store_directory;
            this.response_engine = response_engine;
            this.get_view_model = get_view_model;
        }

        public void process(Request request)
        {
            response_engine.prepare(get_view_model(request, store_directory));
        }
    }
}