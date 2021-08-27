using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.ImgButton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImgButton : ContentPage
    {
        public ImgButton()
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