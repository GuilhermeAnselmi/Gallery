using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Progress
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Progress : ContentPage
    {
        double count = 0.0;

        public Progress()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            count += 0.1;
            bar.ProgressTo(count, 500, Easing.BounceOut);
        }
    }
}