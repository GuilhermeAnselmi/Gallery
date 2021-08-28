using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OpenContent(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Pages.Content.ContentOne();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenNavigate(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Pages.Navigation.NavigationOne());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenCarousel(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Pages.Carousel.Carousel());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenTabbed(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Pages.Tabbed.TabbedOne());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenMaster(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Pages.Menu.LateralMenu());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Pages.Modal.ContentOne());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenStack(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Stack.Stack());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Grade.Grade());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenAbsolut(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Absolut.Absolut());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenRelative(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Relative.Relative());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenFlex(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Flex.Flex());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenScroll(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Scroll.Scroll());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenContentV(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Cont.Cont());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenFraming(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.Framing.Framing());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenBox(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Box.Box());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenLbl(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Lbl.Lbl());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenBtn(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Btn.Btn());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenImgBtn(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.ImgButton.ImgButton());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenImg(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Img.Img());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenEntr(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Entr.Entr());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenEdit(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Edit.Edit());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenCheck(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Check.Check());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenRadio(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Radio.Radio());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenSwt(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Swt.Swt());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenStep(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Step.Step());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenSlid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Slid.Slid());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenPick(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Pick.Pick());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenDatePick(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.DatePick.DatePick());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenTimePick(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.TimePick.TimePick());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenIndicator(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Indicator.Indicator());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenProgress(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Progress.Progress());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenSearch(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Search.Search());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenRe(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Re.Re());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void OpenSwipe(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controls.Swipe.Swipe());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}