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
    public partial class NavigationTree : ContentPage
    {
        public NavigationTree()
        {
            InitializeComponent();
        }

        private void InsertList(object sender, EventArgs e)
        {
            /*
            Navigation.InsertPageBefore(
                new NavigationOne(),
                this
            );
            */
            
            Navigation.InsertPageBefore(
                new InsertedPage(),
                Navigation.NavigationStack[0]
            );
        }

        private void RemoveList(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }

        private void ReturnOne(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void Returning(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            // return base.OnBackButtonPressed();
            return true;
        }
    }
}