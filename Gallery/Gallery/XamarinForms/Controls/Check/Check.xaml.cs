using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Check
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Check : ContentPage
    {
        public Check()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblInfo.Text = (e.Value ? "Marcado" : "Desmarcado");
        }
    }
}