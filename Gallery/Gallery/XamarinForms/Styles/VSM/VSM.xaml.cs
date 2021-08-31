using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Styles.VSM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VSM : ContentPage
    {
        public VSM()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //e.NewTextValue.Contain("#");
            if (e.NewTextValue.StartsWith("#"))
            {
                //Valid
                VisualStateManager.GoToState((Entry)sender, "Valid");
            }
            else
            {
                //Invalid
                VisualStateManager.GoToState((Entry)sender, "Invalid");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            txtHex.IsEnabled = !txtHex.IsEnabled;
        }
    }
}