﻿using Restaurant.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Menu
    {
        public Menu(int userID)
        {
            OptionList menu = new OptionList("Menu");
            menu.Add(new PlaceOrderOption("Złóż zamówienie",userID));
            menu.Add(new CheckOrdersPage("Moje zamówienia",userID));
            menu.Add(new Exit("Wyloguj"));
            menu.Start();

            System.Windows.Forms.Application.Restart();
            Environment.Exit(0);

        }
    }
}
