namespace nothinbutdotnetstore.web.infrastructure.webforms
{
    public interface WebFormRegistry
    {
        string get_path_to_view_for<ViewModel>();
    }
}