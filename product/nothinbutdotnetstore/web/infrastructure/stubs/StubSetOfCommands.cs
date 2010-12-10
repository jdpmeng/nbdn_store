using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.web.infrastructure.stubs
{
    public class StubSetOfCommands : IEnumerable<RequestCommand>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<RequestCommand> GetEnumerator()
        {
            yield return new DefaultRequestCommand(IncomingRequest.is_for<ViewMainDepartmentsInTheStore>(),
                                                   new ViewMainDepartmentsInTheStore());
            yield return new DefaultRequestCommand(x => true,
                                                   new ViewDepartmentsInADepartment());
            yield return new DefaultRequestCommand(x => true,
                                                   new ViewProductsInADepartment());
        }
    }
}