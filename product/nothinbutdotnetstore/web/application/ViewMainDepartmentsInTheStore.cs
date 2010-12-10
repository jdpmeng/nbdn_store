using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class ViewMainDepartmentsInTheStore : ApplicationCommand
    {
        StoreDirectory store_directory;
        ResponseEngine response_engine;

        public ViewMainDepartmentsInTheStore() : this(new StubStoreDirectory(),
                                                      new StubResponseEngine())
        {
        }

        public ViewMainDepartmentsInTheStore(StoreDirectory store_directory, ResponseEngine response_engine)
        {
            this.store_directory = store_directory;
            this.response_engine = response_engine;
        }

        public void process(Request request)
        {
            response_engine.prepare(store_directory.all_main_departments());
        }
    }
}