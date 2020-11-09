using SurveyApplication.Models;
using SurveyApplication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyApplication.Controllers
{
    public class SurveyController : Controller
    {
        private SurveyDbContext db = new SurveyDbContext();
        //
        // GET: /Survey/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel survey)
        {
            //create user
            var user = db.User.Add(new User()
            {
                Surname = survey.Surname,
                FirstName = survey.FirstName,
                ContactNumber = survey.ContactNumber,
                Date = survey.Date,
                Age = survey.Age
            });

            db.SaveChanges();

            //TODO: create user's favourite food

            //TODO: create user's rating

            return View("Index");
        }
        
        [HttpGet]
        public ActionResult SurveyResults()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
	}
}