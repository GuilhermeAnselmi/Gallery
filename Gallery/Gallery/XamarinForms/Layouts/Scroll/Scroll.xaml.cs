using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Layouts.Scroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scroll : ContentPage
    {
        public Scroll()
        {
            InitializeComponent();
        }

        private void Scrolling(object sender, EventArgs e)
        {
            //ScrollingMe é o name do objeto scroll
            //ScrollingMe.ScrollToAsync(0, 0, true);
            ScrollingMe.ScrollToAsync(Secondary, ScrollToPosition.Start, true);
        }

        private void ScrolledMe(object sender, ScrolledEventArgs e)
        {
            position.Text = e.ScrollX + " - " + e.ScrollY;
        }
    }
}