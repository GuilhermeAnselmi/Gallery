using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Lists.List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List : ContentPage
    {
        public List()
        {
            InitializeComponent();

            list.ItemsSource = GetListMarca();
        }

        private List<Marca> GetListMarca()
        {
            return new List<Marca>()
            {
                GetListCarFiat(),
                GetListCarFord(),
            };
        }

        private Marca GetListCarFord()
        {
            var Ford = new Marca()
            {
                new Car{
                    Name = "Ka",
                    Motor = "1.0 - 1.3",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Ka Sedan",
                    Motor = "1.0 - 1.3",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Fusion",
                    Motor = "2.0+",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Exosport",
                    Motor = "1.8 - 2.0",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Novo Edge",
                    Motor = "2.4 - 3.0",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering, Ar Condisionado"
                },
                new Car{
                    Name = "Ranger",
                    Motor = "3.2",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Mustang",
                    Motor = "5.0",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
            };

            Ford.Name = "Ford";

            return Ford;
        }

        private Marca GetListCarFiat()
        {
            var Fiat = new Marca()
            {
                new Car{ 
                    Name = "Mobi", 
                    Motor = "1.0", 
                    Description = "Mobi is the car in evolutuin.", 
                    Serie = "Airbag, Hydraulic Steering" 
                },
                new Car{
                    Name = "Uno",
                    Motor = "1.0",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Argo",
                    Motor = "1.0 - 1.4",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Cronos",
                    Motor = "1.0 - 1.4",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Toro",
                    Motor = "1.8, 2.4, 2.0TD",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering, Ar Condisionado"
                },
                new Car{
                    Name = "Grand Siena",
                    Motor = "1.0 - 1.8",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Strada",
                    Motor = "1.8",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Dublò",
                    Motor = "1.8",
                    Description = "Mobi is the car in evolutuin. Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
            };

            Fiat.Name = "Fiat";

            return Fiat;
        }

        private Marca GetListCarRenault()
        {
            var Renault = new Marca()
            {
                new Car{
                    Name = "Kwid",
                    Motor = "1.0",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Sandero",
                    Motor = "1.0 - 1.6",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
                new Car{
                    Name = "Logan",
                    Motor = "1.6",
                    Description = "Mobi is the car in evolutuin.",
                    Serie = "Airbag, Hydraulic Steering"
                },
            };

            Renault.Name = "Renault";

            return Renault;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var parameter = ((MenuItem)sender).CommandParameter;
            var car = (Car)parameter;

            DisplayAlert("Visualizar", $"Registro: {car.Name}", "Ok");
        }

        private void list_Refreshing(object sender, EventArgs e)
        {
            var marcas = new List<Marca>()
            {
                GetListCarRenault(),
            };

            list.ItemsSource = marcas;

            list.IsRefreshing = false;
            // list.EndRefresh(); Faz o mesmo que o de cima
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public string Motor { get; set; }
        public string Description { get; set; }
        public string Serie { get; set; }
    }

    public class Marca : List<Car>
    {
        public string Name { get; set; }
    }
}