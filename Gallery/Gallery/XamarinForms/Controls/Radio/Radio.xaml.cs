using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Radio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Radio : ContentPage
    {
        public Radio()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblInfo.Text = ((RadioButton)sender).Content.ToString();
        }
    }
}