using System.Web.UI;

namespace nothinbutdotnetstore.web.infrastructure
{
    public class SimpleViewFor<ViewModel> : Page, ViewFor<ViewModel>
    {
        public ViewModel model { get; set; }
    }
}