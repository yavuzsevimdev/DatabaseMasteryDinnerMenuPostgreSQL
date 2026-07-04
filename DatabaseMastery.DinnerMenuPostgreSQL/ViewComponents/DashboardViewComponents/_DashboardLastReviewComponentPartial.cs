using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.DinnerMenuPostgreSQL.ViewComponents.DashboardViewComponents
{
    public class _DashboardLastReviewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
