using System.Web;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.specs.utility;
using nothinbutdotnetstore.web.infrastructure;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    public class ResponseEngineSpecs
    {
        public abstract class concern : Observes<ResponseEngine,
                                            WebFormResponseEngine>
        {
        }

        [Subject(typeof(WebFormResponseEngine))]
        public class when_preparing_a_view_model_for_display : concern
        {
            Establish c = () =>
            {
                the_context = ObjectFactory.create_http_context();
                provide_a_basic_sut_constructor_argument<ContextResolver>(() => the_context);
                view_factory = the_dependency<ViewFactory>();
                view = an<IHttpHandler>();
                our_model = new OurModel();

                view_factory.Stub(x => x.create_view_for(our_model)).Return(view);
            };

            Because b = () =>
                sut.prepare(our_model);

            It should_create_the_logical_view_for_the_view_model = () =>
                view_factory.received(x => x.create_view_for(our_model));

            It should_tell_the_view_to_process_using_the_active_context = () =>
                view.received(x => x.ProcessRequest(the_context));



            static OurModel our_model;
            static ViewFactory view_factory;
            static IHttpHandler view;
            static HttpContext the_context;
        }

        public class OurModel
        {
        }
    }
}