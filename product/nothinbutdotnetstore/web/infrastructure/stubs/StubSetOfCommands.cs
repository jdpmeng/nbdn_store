using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.tasks;
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
                                                   new View<IEnumerable<Department>>(new GetTheMainDepartments()));
        }

        public class GetTheMainDepartments : Query<IEnumerable<Department>>
        {
            public IEnumerable<Department> run_using(Request request, StoreDirectory directory)
            {
                throw new NotImplementedException();
            }
        }
    }
}