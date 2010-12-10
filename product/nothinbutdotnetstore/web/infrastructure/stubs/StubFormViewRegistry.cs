using nothinbutdotnetstore.web.infrastructure.webforms;

namespace nothinbutdotnetstore.web.infrastructure.stubs
{
    public class StubFormViewRegistry : WebFormRegistry
    {
        public string get_path_to_view_for<ViewModel>()
        {
            return "~/views/DepartmentBrowser.aspx";
        }
    }
}