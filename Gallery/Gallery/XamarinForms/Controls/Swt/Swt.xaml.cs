using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Swt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Swt : ContentPage
    {
        public Swt()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            lblInfo.Text = e.Value ? "Marcado" : "Desmarcado";
        }
    }
}