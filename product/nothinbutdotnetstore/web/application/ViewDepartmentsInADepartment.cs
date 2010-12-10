using System;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class ViewDepartmentsInADepartment : CommandBase
    {

        public ViewDepartmentsInADepartment():this(new StubStoreDirectory(),
            new StubResponseEngine())
        {
        }

        public ViewDepartmentsInADepartment(StoreDirectory store_directory, ResponseEngine response_engine) : base(store_directory,response_engine)
        {

        }

        public override void process(Request request)
        {
            response_engine.prepare(store_directory.all_departments_in(request.map<Department>()));
        }
    }
}