using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class View<ViewModel> : ApplicationCommand
    {
        StoreDirectory store_directory;
        ResponseEngine response_engine;
        Query<ViewModel> query;

        public View(Query<ViewModel> query)
        {
            this.query = query;
        }

        public View(StoreDirectory store_directory, ResponseEngine response_engine,
                    Query<ViewModel> query)
        {
            this.store_directory = store_directory;
            this.response_engine = response_engine;
            this.query = query;
        }

        public void process(Request request)
        {
            response_engine.prepare(query.run_using(request, store_directory));
        }
    }
}