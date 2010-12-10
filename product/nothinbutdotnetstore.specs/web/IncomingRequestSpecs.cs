using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.web;
using nothinbutdotnetstore.web.infrastructure;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    public class IncomingRequestSpecs
    {
        public abstract class concern : Observes<FrontController,
                                            IncomingRequest>

        {
        }

        [Subject(typeof(IncomingRequest))]
        public class when_getting_request_specification : concern
        {
            Establish c = () =>
            {
                RequestSpecification request_specification = An<RequestSpecification>();
            };

            private Because b = () =>
                                sut.is_for<ApplicationCommand>();

            It should_return_delegate_for_command = () =>
                request_specification.;

            private static RequestSpecification request_specification;
        }
    }
}