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
    public partial class LateralMenu : MasterDetailPage
    {
        public LateralMenu()
        {
            InitializeComponent();
        }

        private void PageOne(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MenuOne());
            IsPresented = false;
        }

        private void PageTwo(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MenuTwo());
            IsPresented = false;
        }

        private void PageTree(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MenuTree());
            IsPresented = false;
        }
    }
}