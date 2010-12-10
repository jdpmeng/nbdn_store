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

        [Subject(typeof(WebFormViewFactory))]
        public class when_creating_a_view_for_a_view_model : concern
        {
            Establish c = () =>
            {
                view = an<ViewFor<OurModel>>();
                the_model = new OurModel();
                web_form_path = "the_path";
                provide_a_basic_sut_constructor_argument<FormFactory>((x, y) => view);
                web_form_registry = the_dependency<WebFormRegistry>();

                web_form_registry.Stub(x => x.get_path_to_view_for<OurModel>()).Return(web_form_path);
            };

            Because b = () =>
                result = sut.create_view_for(the_model);

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
        }

        class OurModel
        {
        }
    }
}