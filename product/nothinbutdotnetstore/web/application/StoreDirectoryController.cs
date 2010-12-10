using System.Collections.Generic;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.web.application
{
    public class StoreDirectoryController
    {
        StoreDirectory directory;

        public StoreDirectoryController(StoreDirectory directory)
        {
            this.directory = directory;
        }

        public IEnumerable<Department> all_main_departments()
        {
            return directory.all_main_departments();
        }

        public IEnumerable<Department> all_departments_in(Department department)
        {
            return directory.all_departments_in(department);
        }

        public IEnumerable<Product> all_products_in(Department department)
        {
            return directory.all_products_in(department);
        }
    }
}