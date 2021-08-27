using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Layouts.Cont
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardAuthor : ContentView
    {
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(CardAuthor));
        public static readonly BindableProperty DescrProperty = BindableProperty.Create("Descr", typeof(string), typeof(CardAuthor));
        public static readonly BindableProperty BoxViewColorProperty = BindableProperty.Create("BoxViewColor", typeof(Color), typeof(CardAuthor));

        public string Name 
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public string Descr
        {
            get { return (string)GetValue(DescrProperty); }
            set { SetValue(DescrProperty, value); }
        }
        public Color BoxViewColor
        {
            get { return (Color)GetValue(BoxViewColorProperty); }
            set { SetValue(BoxViewColorProperty, value); }
        }

        public CardAuthor()
        {
            InitializeComponent();
        }
    }
}