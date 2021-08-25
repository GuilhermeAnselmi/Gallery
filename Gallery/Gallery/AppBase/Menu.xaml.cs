﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OpenContent(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Pages.Content.ContentOne();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenNavigate(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Pages.Navigation.NavigationOne());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenCarousel(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Pages.Carousel.Carousel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenTabbed(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Pages.Tabbed.TabbedOne();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenMaster(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Pages.Menu.LateralMenu();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Pages.Modal.ContentOne();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenStack(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Stack.Stack();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Grade.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenAbsolut(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Absolut.Absolut();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}