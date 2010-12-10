namespace nothinbutdotnetstore.web.infrastructure
{
    public interface ViewFactory
    {
        void create_view_for<ViewModel>(ViewModel view_view_model);
    }
}