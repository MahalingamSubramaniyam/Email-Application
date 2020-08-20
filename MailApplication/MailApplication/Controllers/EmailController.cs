using MailApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MailApplication.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Email()
        {
            var model = new EmailModel();
            ViewBag.Message = TempData["Message"];
            TempData["Message"] = "";
            return View(model);
        }
        [HttpPost]
        public ActionResult SendEmail(EmailModel model)
        {
            try
            {
                TempData["Message"] = model.SendMail(model);
            }
            catch (Exception)
            {
                TempData["Message"] = "Mail sent error!";
            }
            return RedirectToAction("Email");
        }

    }
}