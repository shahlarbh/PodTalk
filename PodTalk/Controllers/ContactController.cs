﻿using Microsoft.AspNetCore.Mvc;
using PodTalk.DataAccessLayer;
using PodTalk.ViewModels;

namespace PodTalk.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var contact = _dbContext.Contacts.FirstOrDefault();

            var viewModel = new ContactViewModel
            {
                Contacts = contact
            };

            return View(viewModel);
        }
    }
}
