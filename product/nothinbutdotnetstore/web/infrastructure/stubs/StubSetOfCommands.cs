using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.application.model;

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
            yield return new DefaultRequestCommand(x => true,
                                                   new View<IEnumerable<Department>>((x,y) => y.all_main_departments()));

            yield return new DefaultRequestCommand(x => true,
                                                   new View<IEnumerable<Department>>((x,y) => y.all_departments_in(x.map<Department>())));
            yield return new DefaultRequestCommand(x => true,
                                                   new View<IEnumerable<Product>>(new GetTheProductsInADepartment().get_details));
        }
    }
}