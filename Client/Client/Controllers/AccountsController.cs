using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class AccountsController : Controller
    {
        ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
        // GET: Accounts
        public ActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,CustomerCode,Money,Name,SercurityCode")] Client.ServiceReference1.Account account)
        {
            var acc = serviceClient.GetAccount(account.CustomerCode, account.SercurityCode);
            if(acc == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return RedirectToAction("Run", acc);
        }

        public ActionResult Run(Client.ServiceReference1.Account account)
        {
            return View(account);
        }

        public ActionResult Go(String sCode, string rCode, int amount)
        {
            Boolean correct = serviceClient.TransferMoney(sCode, rCode, amount);
            if(correct == false)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return RedirectToAction("Create");
        }
    }
}