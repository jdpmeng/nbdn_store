using System.Collections.Generic;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.tasks
{
    public interface Repository
    {
        IEnumerable<Department> get_all_the_main_departments_in_the_store();
        IEnumerable<Department> get_all_departments_in(Department department);
        IEnumerable<Product> get_all_products_in(Department department);
    }
}