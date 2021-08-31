using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Media
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Element : ContentPage
    {
        public Element()
        {
            InitializeComponent();
        }

        private void Play(object sender, EventArgs e)
        {
            vidControl.Play();
        }

        private void Pause(object sender, EventArgs e)
        {
            vidControl.Pause();
        }

        private void Stop(object sender, EventArgs e)
        {
            vidControl.Stop();
        }

        private void Volume(object sender, ValueChangedEventArgs e)
        {
            vidControl.Volume = e.NewValue;
            lblVol.Text = e.NewValue.ToString();
        }
    }
}