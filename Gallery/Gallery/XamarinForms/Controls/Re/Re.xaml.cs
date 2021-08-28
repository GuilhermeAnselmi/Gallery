using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Re
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Re : ContentPage
    {
        public Re()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            lblInfo.Text = DateTime.Now.ToString();

            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}