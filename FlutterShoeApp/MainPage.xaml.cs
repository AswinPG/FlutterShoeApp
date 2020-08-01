using FlutterShoeApp.Models;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlutterShoeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<ShoeDetail> shoeDetails = new List<ShoeDetail>()
            {
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "120 $",
                    ImageUrl = "b.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Puma",
                    Price = "800 $",
                    ImageUrl = "c.jpg"
                },
                new ShoeDetail()
                {
                    Name="Soccer",
                    Company= "Nike",
                    Price = "600 $",
                    ImageUrl = "d.jpg"
                },
                new ShoeDetail()
                {
                    Name="Casual",
                    Company= "Bata",
                    Price = "125 $",
                    ImageUrl = "e.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "128 $",
                    ImageUrl = "a.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Sparx",
                    Price = "1220 $",
                    ImageUrl = "f.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "90 $",
                    ImageUrl = "b.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Puma",
                    Price = "890 $",
                    ImageUrl = "c.jpg"
                },
                new ShoeDetail()
                {
                    Name="Soccer",
                    Company= "Nike",
                    Price = "680 $",
                    ImageUrl = "d.jpg"
                },
                new ShoeDetail()
                {
                    Name="Casual",
                    Company= "Bata",
                    Price = "120 $",
                    ImageUrl = "e.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "1350 $",
                    ImageUrl = "a.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Sparx",
                    Price = "12900 $",
                    ImageUrl = "f.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "12780 $",
                    ImageUrl = "b.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Puma",
                    Price = "89800 $",
                    ImageUrl = "c.jpg"
                },
                new ShoeDetail()
                {
                    Name="Soccer",
                    Company= "Nike",
                    Price = "60045 $",
                    ImageUrl = "d.jpg"
                },
                new ShoeDetail()
                {
                    Name="Casual",
                    Company= "Bata",
                    Price = "12078 $",
                    ImageUrl = "e.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "123750 $",
                    ImageUrl = "a.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Sparx",
                    Price = "120678 $",
                    ImageUrl = "f.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "120 $",
                    ImageUrl = "b.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Puma",
                    Price = "800 $",
                    ImageUrl = "c.jpg"
                },
                new ShoeDetail()
                {
                    Name="Soccer",
                    Company= "Nike",
                    Price = "600 $",
                    ImageUrl = "d.jpg"
                },
                new ShoeDetail()
                {
                    Name="Casual",
                    Company= "Bata",
                    Price = "120 $",
                    ImageUrl = "e.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "120 $",
                    ImageUrl = "a.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Sparx",
                    Price = "120 $",
                    ImageUrl = "f.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "120 $",
                    ImageUrl = "b.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Puma",
                    Price = "800 $",
                    ImageUrl = "c.jpg"
                },
                new ShoeDetail()
                {
                    Name="Soccer",
                    Company= "Nike",
                    Price = "600 $",
                    ImageUrl = "d.jpg"
                },
                new ShoeDetail()
                {
                    Name="Casual",
                    Company= "Bata",
                    Price = "120 $",
                    ImageUrl = "e.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Nike",
                    Price = "120 $",
                    ImageUrl = "a.jpg"
                },
                new ShoeDetail()
                {
                    Name="Sneakers",
                    Company= "Sparx",
                    Price = "120 $",
                    ImageUrl = "f.jpg"
                },
            };
            MainCollectionView.ItemsSource = shoeDetails;

        }

        private async void MainCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainCollectionView.SelectedItem != null)
            {
                ShoeDetail detail = e.CurrentSelection[0] as ShoeDetail;
                DetailPage Page = new DetailPage(detail);
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, detail.Price);
                await Navigation.PushAsync(Page);
                
            }
            MainCollectionView.SelectedItem = null;
        }
    }
}
