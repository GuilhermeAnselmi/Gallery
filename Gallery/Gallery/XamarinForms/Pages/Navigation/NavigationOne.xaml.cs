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
    public partial class NavigationOne : ContentPage
    {
        public NavigationOne()
        {
            InitializeComponent();
        }

        private void PageTwo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationTwo());
        }
    }
}