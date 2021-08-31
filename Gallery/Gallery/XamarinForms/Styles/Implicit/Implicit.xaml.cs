using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Styles.Implicit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Implicit : ContentPage
    {
        public Implicit()
        {
            InitializeComponent();
        }
    }
    public class btn : Button
    {
        public btn()
        {
            Text = "Default Buttons";
        }
    }
}