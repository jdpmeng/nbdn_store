using System;
using System.Web;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.web.infrastructure;
using nothinbutdotnetstore.web.infrastructure.webforms;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    public class ViewFactorySpecs
    {
        public abstract class concern : Observes<ViewFactory,
                                            WebFormViewFactory>
        {
        }

        class FactoryDetails : IEquatable<FactoryDetails>
        {
            public FactoryDetails(string path, Type type)
            {
                this.path = path;
                this.type = type;
            }

            public FactoryDetails()
            {
            }

            public bool Equals(FactoryDetails other)
            {
                return this.path == other.path &&
                    this.type == other.type;
            }

            public string path { get; set; }
            public Type type { get; set; }
        }

        [Subject(typeof(WebFormViewFactory))]
        public class when_creating_a_view_for_a_view_model : concern
        {
            Establish c = () =>
            {
                view = an<ViewFor<OurModel>>();
                the_model = new OurModel();
                web_form_path = "the_path";
                expected_details = new FactoryDetails{path =  web_form_path,type = typeof(ViewFor<OurModel>)};
                provide_a_basic_sut_constructor_argument<FormFactory>((x, y) =>
                {
                    actual_details = new FactoryDetails(x, y);
                    return view;
                });
                web_form_registry = the_dependency<WebFormRegistry>();

                web_form_registry.Stub(x => x.get_path_to_view_for<OurModel>()).Return(web_form_path);
            };

            Because b = () =>
                result = sut.create_view_for(the_model);

            It should_provide_the_page_factory_with_the_correct_details = () =>
            {
                expected_details.Equals(actual_details).ShouldBeTrue();
            };
  
            It should_return_the_correct_web_form_populated_with_its_view_model = () =>
            {
                result.ShouldEqual(view);
                result.ShouldBeAn<ViewFor<OurModel>>().model.Equals(the_model);
            };

            static IHttpHandler result;
            static ViewFor<OurModel> view;
            static OurModel the_model;
            static WebFormRegistry web_form_registry;
            static string web_form_path;
            static FactoryDetails expected_details;
            static FactoryDetails actual_details;
        }

        public class OurModel
        {
        }
    }
}