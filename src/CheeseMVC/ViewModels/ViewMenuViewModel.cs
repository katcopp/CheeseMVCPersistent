﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        public IList<CheeseMenu> Items { get; set; }
        public Menu Menu { get; set; }
        


        //public AddMenuViewModel() { }
    }
}
