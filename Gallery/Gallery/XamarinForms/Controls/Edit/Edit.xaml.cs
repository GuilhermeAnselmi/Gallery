using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Edit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit : ContentPage
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Focused";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "Unfocused";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblChange.Text = e.NewTextValue.Length.ToString();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblComplete.Text = Texting.Text;
        }
    }
}