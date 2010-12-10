using System;
using System.Collections.Generic;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.web.infrastructure.stubs
{
    public class GetTheDepartmentsInADepartment : Query<IEnumerable<Department>>
    {
        public IEnumerable<Department> run_using(Request request, StoreDirectory directory)
        {
            throw new NotImplementedException();
        }
    }
}