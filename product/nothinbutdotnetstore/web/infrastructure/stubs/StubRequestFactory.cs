using System;
using System.Web;
using nothinbutdotnetstore.stubs;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.web.infrastructure.stubs
{
    public class StubRequestFactory : RequestFactory,AStub
    {
        public Request create_from(HttpContext the_http_context)
        {

            return new StubRequest();
        }

        class StubRequest : Request
        {
            public InputModel map<InputModel>() 
            {
                return default(InputModel);

                var enumerator = new StubSetOfCommands().GetEnumerator();
                enumerator.MoveNext();
                var item = enumerator.Current;

            }
        }
    }
}