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
    public partial class NavigationTwo : ContentPage
    {
        public NavigationTwo()
        {
            InitializeComponent();
        }

        protected void Done(object sender, EventArgs e)
        {
            // Mostra a pagina que veio antes
            //Navigation.NavigationStack[0];
            Navigation.PopAsync();
        }

        protected void PageTree(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationTree());
        }
    }
}