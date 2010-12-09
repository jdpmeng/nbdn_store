using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    class ViewDepartmentsWithinMainDepartmentSpecs
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewDepartmentsWithinMainDepartment>
        {
        }

        [Subject(typeof(ViewDepartmentsWithinMainDepartment))]
        public class when_processing : concern
        {
            Establish c = () =>
            {
                response_engine = the_dependency<ResponseEngine>();
                department_repository = the_dependency<Repository>();
                provide_a_basic_sut_constructor_argument<Department>(the_main_department);
                the_sub_departments = new List<SubDepartment>();
                request = an<Request>();

                department_repository.Stub(x => x.get_all_the_departments_within_the_main_department(the_main_department)).Return(
                    the_sub_departments);
            };

            Because b = () =>
                sut.process(request);

            It should_tell_the_response_to_display_the_departments_within_the_main_department = () =>
                response_engine.received(x => x.prepare(the_sub_departments));

            static Repository department_repository;
            static Request request;
            static IEnumerable<SubDepartment> the_sub_departments;
            static ResponseEngine response_engine;
            private static Department the_main_department;
        }
    }
}
