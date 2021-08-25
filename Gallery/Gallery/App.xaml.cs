using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*
            var nav = new NavigationPage(
                new XamarinForms.Pages.Navigation.NavigationOne()
                );

            MainPage = nav;
            */

            //MainPage = new XamarinForms.Pages.Modal.ContentOne();

            /*
            var carousel = new CarouselPage();
            carousel.Children.Add(new XamarinForms.Pages.Carousel.ContentOne());
            carousel.Children.Add(new XamarinForms.Pages.Carousel.ContentTwo());
            carousel.Children.Add(new XamarinForms.Pages.Carousel.ContentTree());

            carousel.CurrentPage = carousel.Children[1];

            MainPage = carousel;
            */

            //MainPage = new XamarinForms.Pages.Carousel.Carousel();

            /*
            var tabbed = new TabbedPage();
            tabbed.Children.Add(new XamarinForms.Pages.Carousel.ContentOne());
            tabbed.Children.Add(new XamarinForms.Pages.Carousel.ContentTwo());
            tabbed.Children.Add(new XamarinForms.Pages.Carousel.ContentTree());

            tabbed.CurrentPage = tabbed.Children[1];

            MainPage = tabbed;
            */

            //MainPage = new XamarinForms.Pages.Tabbed.TabbedOne();

            /*
            var master = new MasterDetailPage();
            // menu
            master.Master = ;

            // content
            master.Detail = ;
            */

            //MainPage = new XamarinForms.Pages.Menu.LateralMenu();

            MainPage = new AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
