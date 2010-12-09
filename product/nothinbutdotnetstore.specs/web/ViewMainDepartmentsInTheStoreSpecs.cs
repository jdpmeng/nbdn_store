 using System.Collections.Generic;
 using System.Linq;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.web;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.infrastructure;
 using Rhino.Mocks;
 using RhinoMocksExtensions = Rhino.Mocks.RhinoMocksExtensions;

namespace nothinbutdotnetstore.specs.web
{   
    public class ViewMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewMainDepartmentsInTheStore>
        {
        
        }

        [Subject(typeof(ViewMainDepartmentsInTheStore))]
        public class when_observation_name : concern
        {
            private Establish e = () => 
            { 
                request = an<Request>();
                theCommand = the_dependency<ViewMainDepartmentsInTheStore>();
                theDepartments = Enumerable.Range(1, 100).Select(x => an<Department>()).ToList();
                provide_a_basic_sut_constructor_argument<IEnumerable<Department>>(theDepartments);
                theCommand.Stub(x => x.process(request));
            };

            private Because b = () =>
                                    {
                                        response = sut.DisplayAllDepartments();
                                    };

            private It shouldDisplayAllDeptsInTheStore = () =>
                                                             {
                                                                 ShouldExtensionMethods.ShouldEqual(response.GetDeparmentList(),theDepartments)
                                                             };

            private static Request request;
            private static ViewMainDepartmentsInTheStore theCommand;
            private static IEnumerable<Department> theDepartments;
            private static Response response;
        }
    }
}
