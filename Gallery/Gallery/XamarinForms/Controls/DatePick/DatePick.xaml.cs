using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.DatePick
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePick : ContentPage
    {
        public DatePick()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblInfo.Text = e.OldDate + " - " + e.NewDate;
        }
    }
}