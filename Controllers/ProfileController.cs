using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;  // Must import the Models folder for the Profile database class

namespace WebApplication6.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult TheProfile()     // ActionResult name is 'Index()' by default, this was renamed to the view's title, 'TheProfile()'
        {
            List<Profile> profile = new List<Profile>();
            profile.Add(new Models.Profile { FirstName = "Max", LastName = "Voisard", Username = "mvoisard", Address = "11383 Marshall Rd", Birthday = "01/21/1997", Education = "Edison State Community College", Email = "max.voisard@gmail.com", Gender = "Male", Jobs = "Software Developer", Location = "Versailles, OH, USA", PhoneNumber = "(937)-638-4972", PoliticalParty = "Republican", Relationships = "Single", Religion = "Roman Catholic"});
            profile.Add(new Models.Profile { FirstName = "Madonna", LastName = "Ciccone", Username = "madonna", Address = "26784 Madonna St", Birthday = "08/16/1958", Education = "None", Email = "madonna@gmail.com", Gender = "Female", Jobs = "Pop Artist", Location = "Lisbon, Portugal", PhoneNumber = "(583)-495-6681", PoliticalParty = "Democrat", Relationships = "Single", Religion = "Roman Catholic"});
            return View(profile);   // Syntax is <ViewHelperMethod>(<ModelName>)...helper method comes from Controller class, can also be written as 'return new ViewResult();'
            // or you can use the ViewData dictionary to perform the same operation, so 'ViewData["Profile"] = profile;', or ViewBag...'ViewBag.Profile = profile;'
        }
    }
}