using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Slid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slid : ContentPage
    {
        public Slid()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblInfo.Text = e.NewValue.ToString();
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {
            lblStart.Text = "Initial";
        }

        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            lblEnd.Text = "End";
        }
    }
}