using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.TimePick
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePick : ContentPage
    {
        public TimePick()
        {
            InitializeComponent();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                lblInfo.Text = "Time alterado";
            }
        }
    }
}