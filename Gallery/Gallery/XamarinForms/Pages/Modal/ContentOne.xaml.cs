using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Pages.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentOne : ContentPage
    {
        public ContentOne()
        {
            InitializeComponent();
        }

        private void OpenModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ModalPage());
        }
    }
}