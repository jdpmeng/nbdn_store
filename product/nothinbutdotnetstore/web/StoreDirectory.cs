using System.Collections.Generic;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.tasks
{
    public interface StoreDirectory
    {
        IEnumerable<Department> all_main_departments();
        IEnumerable<Department> all_departments_in(Department department);
        IEnumerable<Product> all_products_in(Department department);
    }
}