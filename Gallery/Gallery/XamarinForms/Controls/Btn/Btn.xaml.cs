using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Btn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Btn : ContentPage
    {
        public Btn()
        {
            InitializeComponent();
        }

        private void evetPress(object sender, EventArgs e)
        {
            lblPress.Text = "Pressed";
        }

        private void evetRelease(object sender, EventArgs e)
        {
            lblRelease.Text = "Released";
        }

        private void evetClick(object sender, EventArgs e)
        {
            lblClick.Text = "Clicked";
        }
    }
}