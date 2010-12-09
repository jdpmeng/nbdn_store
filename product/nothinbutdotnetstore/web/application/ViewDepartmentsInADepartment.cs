using System;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class ViewDepartmentsInADepartment : ApplicationCommand
    {
        Repository repository;
        ResponseEngine response_engine;

        public ViewDepartmentsInADepartment():this(new StubRepository(),
            new StubResponseEngine())
        {
        }

        public ViewDepartmentsInADepartment(Repository repository, ResponseEngine response_engine)
        {
            this.repository = repository;
            this.response_engine = response_engine;
        }

        public void process(Request request)
        {
            response_engine.prepare(repository.get_all_departments_in(request.map<Department>()));
        }
    }
}