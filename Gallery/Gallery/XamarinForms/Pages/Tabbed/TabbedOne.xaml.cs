using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Pages.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedOne : TabbedPage
    {
        public TabbedOne()
        {
            InitializeComponent();

            CurrentPage = Children[0];
        }
    }
}