using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertedPage : ContentPage
    {
        public InsertedPage()
        {
            InitializeComponent();
        }

        private void Home(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(
                new NavigationOne()
            );
        }
    }
}