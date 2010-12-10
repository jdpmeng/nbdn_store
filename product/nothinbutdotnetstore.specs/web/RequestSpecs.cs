using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.web.infrastructure;

namespace nothinbutdotnetstore.specs.web
{
    public class RequestSpecs
    {
        public abstract class concern : Observes<Request,
                                            DefaultRequest>
        {
        }

        [Subject(typeof(DefaultRequest))]
        public class when_using_a_default_request_to_map : concern
        {
            private Establish e = () =>
                                      {


                                      };

            private Because b = () => { the_return_model = sut.map<OurModel>(); };

            private It should_return_the_mapped_model = () =>
                                                            {
                                                                the_return_model.ShouldBeAn<OurModel>();
                                                                the_return_model.ShouldNotBeNull();
                                                            };

            private static OurModel the_return_model;
        }

    }

    public class OurModel
    {
        
    }
}
