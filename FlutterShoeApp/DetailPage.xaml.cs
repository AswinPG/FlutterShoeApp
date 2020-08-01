using FlutterShoeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlutterShoeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(ShoeDetail detail)
        {
            InitializeComponent();
            BackImage.Source = detail.ImageUrl;
            HeadingLabel.Text = detail.Name;
        }
    }
}