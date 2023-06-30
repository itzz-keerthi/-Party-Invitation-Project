﻿using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() {  
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            //todo: store response from guest
            Repository.AddResponse(guestResponse);
            return View("Thanks",guestResponse);
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r=>r.WillAttend==true));
        }
    }
}