using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.webforms;

namespace nothinbutdotnetstore.web.application
{
    public class ViewProductsInADepartment : ApplicationCommand
    {
        StoreDirectory store_directory;
        ResponseEngine response_engine;

        public ViewProductsInADepartment() : this(new StubStoreDirectory(),
                                                  new WebFormResponseEngine())
        {
        }

        public ViewProductsInADepartment(StoreDirectory store_directory, ResponseEngine response_engine)
        {
            this.store_directory = store_directory;
            this.response_engine = response_engine;
        }

        public void process(Request request)
        {
            response_engine.prepare(store_directory.all_products_in(request.map<Department>()));
        }
    }
}