using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Swipe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Swipe : ContentPage
    {
        public Swipe()
        {
            InitializeComponent();
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            lblDetalhe.Text = "Detalhes: " + DateTime.Now;
        }

        private void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            lblEditar.Text = "Editar: " + DateTime.Now;
        }

        private void SwipeItem_Invoked_2(object sender, EventArgs e)
        {
            lblExcluir.Text = "Excluir: " + DateTime.Now;
        }

        private void SwipeView_SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            lblStart.Text = "Start: " + DateTime.Now + " : " + e.SwipeDirection;
        }

        private void SwipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            lblChange.Text = "Change: " + DateTime.Now + " : " + e.Offset;
        }

        private void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            lblEnd.Text = "End: " + DateTime.Now + " : " + e.SwipeDirection;
        }
    }
}