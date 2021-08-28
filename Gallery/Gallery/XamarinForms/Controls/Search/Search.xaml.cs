using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblOne.Text = ((SearchBar)sender).Text;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            lblTwo.Text = "Searched";
        }
    }
}