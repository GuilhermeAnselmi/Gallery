using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Img
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Img : ContentPage
    {
        public Img()
        {
            InitializeComponent();

            //img01.Source = ImageSource.FromResource("Gallery.XamarinForms.Controls.Img.banner.jpg");

            // From Stream
            // Download -> System.IO
            // Após converter a imagem para stream
            //img01.Source = ImageSource.FromStream(System.IO.Stream);
        }
    }
}