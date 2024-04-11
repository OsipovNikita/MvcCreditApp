﻿using Microsoft.AspNetCore.Mvc;
using MvcCreditApp.Data;
using MvcCreditApp.Models;
using System.Diagnostics;

namespace MvcCreditApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CreditContext db;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CreditContext context)
        {
            _logger = logger;
            db = context;
        }


        public IActionResult Index()
        {
            GiveCredits();
            //var allCredits = db.Credits.ToList<Credit>();
            //ViewBag.Credits = allCredits;
            return View();
        }
        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
          //  Credit cd = db.Credits.ToList<Credit>().Find(a=>a.Head == newBid.CreditHead);
          //  newBid.CreditId = cd.CreditId;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, ";// + newBid.Name + ", за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
