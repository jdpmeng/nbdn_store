using System.Collections.Generic;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    public class ViewMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewMainDepartmentsInTheStore>
        {
        }

        [Subject(typeof(ViewMainDepartmentsInTheStore))]
        public class when_processing : concern
        {
            Establish c = () =>
            {
                response_engine = the_dependency<ResponseEngine>();
                department_store_directory = the_dependency<StoreDirectory>();
                the_main_departments = new List<Department>();
                request = an<Request>();

                department_store_directory.Stub(x => x.all_main_departments()).Return(
                    the_main_departments);
            };

            Because b = () =>
                sut.process(request);

            It should_tell_the_response_to_display_the_main_departments = () =>
                response_engine.received(x => x.prepare(the_main_departments));

            static StoreDirectory department_store_directory;
            static Request request;
            static IEnumerable<Department> the_main_departments;
            static ResponseEngine response_engine;
        }
    }
}