﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.Controls.Web
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Web : ContentPage
    {
        public Web()
        {
            InitializeComponent();

            var html = new HtmlWebViewSource();

            html.Html =
                @"
                <head>
                    <style>
                        .title {
                            color: 'red';
                        }
                    </style>
                </head>
                <html>
                    <body>
                        <h1 class='title'>Eu sou HTML Local</h1>
                        <form>
                            <input type='number' placeholder='Insira um numero' />
                            <input type='submit' value='Enviar' />
                        </form>
                    </body>
                </html>";

            Web02.Source = html;

            // Para carregar o html internamente, deve ser criada a IBaseUrl interface, e uma baseurl em cada
            // tipo de projeto
            var path = new UrlWebViewSource();
            var BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            path.Url = Path.Combine(BaseUrl, "index.html");
            Web03.Source = path;
        }
    }
}