using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class MenuController : Controller
    {
        private CheeseDbContext context;

        public MenuController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Menu> menus = context.Menus.ToList();
            return View(menus);
        }


        public IActionResult Add()
        {
            AddMenuViewModel addMenuViewModel = new AddMenuViewModel();
            return View(addMenuViewModel);
        }

        //[HttpPost]
        //public IActionResult Add() //AddMenuViewModel MenuViewModel addMenuViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Menu newMenu = new Menu
        //        {
        //            //Name = addMenuViewModel.Name
        //        };

        //        context.Menus.Add(newMenu);
        //        context.SaveChanges();

        //        return Redirect("/Menu");
        //    }
        //    return View(); // addMenuViewModel);
        //}

        //public IActionResult ViewMenu(int id)
        //{
        //    List<CheeseMenu>
        //}

    }
}
