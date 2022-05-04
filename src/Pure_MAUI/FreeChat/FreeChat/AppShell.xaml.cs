﻿using FreeChat.Services.Navigation;
using FreeChat.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
            Routing.RegisterRoute(Constants.MessagesPageUrl, typeof(MessagesPage));
        }
    }
}