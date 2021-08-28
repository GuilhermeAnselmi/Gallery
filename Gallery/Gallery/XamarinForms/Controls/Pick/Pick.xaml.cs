using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Pick
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pick : ContentPage
    {
        public Pick()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = ((Picker)sender).SelectedIndex + " - " + ((Picker)sender).SelectedItem;
        }

        private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (((Picker)sender).SelectedIndex == 0)
            {
                ((Picker)sender).SelectedIndex = -1;
            }
        }
    }
}