using System.Collections.Generic;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.web.infrastructure.stubs
{
    public class GetTheProductsInADepartment : Query<IEnumerable<Product>>
    {
        public IEnumerable<Product> run_using(Request request, StoreDirectory directory)
        {
            return directory.all_products_in(request.map<Department>());
        }
    }
}