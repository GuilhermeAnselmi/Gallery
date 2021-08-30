using Gallery.XamarinForms.Controls.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(Gallery.UWP.BaseUrl_UWP))]
namespace Gallery.UWP
{
    public class BaseUrl_UWP : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///Assets//";
        }
    }
}
