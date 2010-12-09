using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.infrastructure;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    public class ViewProductsInDepartmentSpecs
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewProductsInDepartment>
        {
        }

        [Subject(typeof(ViewProductsInDepartment))]
        public class when_processing : concern
        {
            Establish c = () =>
            {
                response_engine = the_dependency<ResponseEngine>();
                product_repository = the_dependency<Repository>();
                
                parent_department = new Department();
                request = an<Request>();

                request.Stub(x => x.map<Department>()).Return(
                    parent_department);

                product_repository.Stub(x => x.get_all_products_in(parent_department)).Return(
                    the_products);
            };

            Because b = () =>
                sut.process(request);

            It should_tell_the_response_to_display_the_products_in_a_department = () =>
                response_engine.received(x => x.prepare(the_products));

            static Repository product_repository;
            static Request request;
            private static IEnumerable<Product> the_products;
            static ResponseEngine response_engine;
            private static Department parent_department;


        }
    }
}
