using nothinbutdotnetstore.tasks;

namespace nothinbutdotnetstore.web.infrastructure.stubs
{
    public interface Query<ViewModel>
    {
        ViewModel run_using(Request request, StoreDirectory directory);
    }
}