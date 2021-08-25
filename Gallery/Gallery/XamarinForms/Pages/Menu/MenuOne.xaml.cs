using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Pages.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuOne : ContentPage
    {
        public MenuOne()
        {
            InitializeComponent();
        }

        private void MenuOpen(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).IsPresented = true;
        }
    }
}