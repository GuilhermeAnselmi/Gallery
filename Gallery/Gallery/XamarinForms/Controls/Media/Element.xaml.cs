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
        private bool RefreshingP = false;

        public Element()
        {
            InitializeComponent();
        }

        private void Play(object sender, EventArgs e)
        {
            vidControl.Play();

            RefreshingP = true;
            RefreshPosition();
        }

        private void RefreshPosition()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () => 
            {
                lblPosition.Text = vidControl.Position.ToString(@"mm\:ss");
                sldPosition.Value = vidControl.Position.Seconds;

                return RefreshingP;
            });
        }

        private void Pause(object sender, EventArgs e)
        {
            vidControl.Pause();
            RefreshingP = false;
        }

        private void Stop(object sender, EventArgs e)
        {
            vidControl.Stop();
            RefreshingP = false;
        }

        private void Volume(object sender, ValueChangedEventArgs e)
        {
            vidControl.Volume = e.NewValue;
            lblVol.Text = e.NewValue.ToString();
        }

        private void Open(object sender, EventArgs e)
        {
            lblDuration.Text = vidControl.Duration.Value.ToString(@"mm\:ss");
            sldPosition.Maximum = vidControl.Duration.Value.TotalSeconds;
        }
    }
}