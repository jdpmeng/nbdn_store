using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.infrastructure;

namespace nothinbutdotnetstore.web.application
{
    public class CommandBase : ApplicationCommand
    {
        protected StoreDirectory store_directory;
        protected ResponseEngine response_engine;

        public CommandBase(StoreDirectory store_directory, ResponseEngine response_engine)
        {
            this.store_directory = store_directory;
            this.response_engine = response_engine;

        }
        public virtual void process(Request request)
        {
            
        }
    }
}
