using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Pages.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carousel : CarouselPage
    {
        public Carousel()
        {
            InitializeComponent();

            CurrentPage = Children[1];
        }
    }
}