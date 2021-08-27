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
    public partial class CardH : ContentView
    {
        private string _title;
        private string _text;
        private Color _colorb;
        public string Title 
        { 
            get { return _title; }
            set { _title = value; CardTitle.Text = _title; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; CardText.Text = _text; }
        }
        public Color ColorB
        {
            get { return _colorb; }
            set { _colorb = value; Card.BackgroundColor = _colorb; }
        }

        public CardH()
        {
            InitializeComponent();

            Card.BackgroundColor = ColorB;
            CardTitle.Text = Title;
            CardTitle.Text = Text;
        }
    }
}