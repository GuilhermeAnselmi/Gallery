using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Step
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step : ContentPage
    {
        public Step()
        {
            InitializeComponent();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblInfo.Text = e.NewValue.ToString();
        }
    }
}