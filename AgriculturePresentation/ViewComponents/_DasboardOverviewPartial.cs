using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DasboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamsCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = c.Announcements.Where(x=>x.Status==true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x=>x.Status==false).Count();

            ViewBag.urunPazarlama = c.Teams.Where(x=>x.Title== "Ürün Pazarlama").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYoneticisi = c.Teams.Where(x=>x.Title== "Bakliyat Yöneticisi").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.sutUreticisi = c.Teams.Where(x=>x.Title== "Süt Üreticisi").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.gubreYoneticisi= c.Teams.Where(x=>x.Title== "Gübre Yöneticisi").Select(y=>y.PersonName).FirstOrDefault();
      
            return View();
        }
    }
}
