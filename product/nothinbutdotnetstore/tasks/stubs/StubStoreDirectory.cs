using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.tasks.stubs
{
    public class StubStoreDirectory : StoreDirectory
    {
        public IEnumerable<Department> all_main_departments()
        {
            return Enumerable.Range(1, 100).Select(x => new Department {name = x.ToString("Department 0")});
        }

        public IEnumerable<Department> all_departments_in(Department department)
        {
            return Enumerable.Range(1, 100).Select(x => new Department {name = x.ToString("SubDepartment 0")});
        }

        public IEnumerable<Product> all_products_in(Department department)
        {
            return Enumerable.Range(1, 100).Select(x => new Product {name = x.ToString("Product 0")});
        }
    }
}