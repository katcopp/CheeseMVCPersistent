using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int CheeseID { get; set; }
        public int MenuID { get; set; }
        
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {
            Cheeses = new List<SelectListItem>();

            foreach (var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }

            Menu = menu;
        }
    }
    
        
}
