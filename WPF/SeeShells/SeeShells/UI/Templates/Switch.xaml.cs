﻿using SeeShells.UI.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeeShells.UI.Templates
{
    /// <summary>
    /// Interaction logic for Switch.xaml
    /// </summary>
    public partial class Switch : UserControl
    {
        public Switch()
        {
            InitializeComponent();
        }
        
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Home.timelinePage == null)
            {
                timeline.IsEnabled = false;

            }
            else
            {
                string timelinePageKey = "timelinepage";
                if (App.pages.ContainsKey(timelinePageKey))
                {
                    App.NavigationService.Navigate(App.pages[timelinePageKey]);
                }
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            string homepage = "homepage";
            if (App.pages.ContainsKey(homepage))
            {
                App.NavigationService.Navigate(App.pages[homepage]);
            }

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            string helppage = "helppage";
            if (App.pages.ContainsKey(helppage))
            {
                App.NavigationService.Navigate(App.pages[helppage]);
            }
        }

        private void About_OnClick(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
    }
}