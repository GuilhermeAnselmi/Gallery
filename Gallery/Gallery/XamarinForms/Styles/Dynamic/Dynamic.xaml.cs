using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Styles.Dynamic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dynamic : ContentPage
    {
        public Dynamic()
        {
            InitializeComponent();
        }

        private void Enter(object sender, EventArgs e)
        {
            Resources["PrimaryColor"] = Color.FromHex(lblColor.Text);
            Resources["ButtonStyle"] = Resources["ButtonStyleDynamic"];
        }
    }
}