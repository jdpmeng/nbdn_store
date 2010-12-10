using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.web.infrastructure;

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
                view_factory = the_dependency<ViewFactory>();
                our_model = new OurModel();
            };

            Because b = () =>
                sut.prepare(our_model);

            It should_create_the_logical_view_for_the_view_model = () =>
                view_factory.received(x => x.create_view_for(our_model));



            static OurModel our_model;
            static ViewFactory view_factory;
        }

        public class OurModel
        {
        }
    }
}