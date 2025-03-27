using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DasboardChartPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 88;
            ViewBag.v2 = 93;
            ViewBag.v3 = 45;
            ViewBag.v4 = 18;
            ViewBag.v5 = 37;
            return View();
        }
    }
}
