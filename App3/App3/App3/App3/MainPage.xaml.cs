using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        int tapCount;
        public MainPage()
        {
            InitializeComponent();
            imageBtn.Source = ImageSource.FromResource("App3.Images.heart1.png");

            /*ImageButton heartBtn = new ImageButton
            {
                Source = "App3.Images.heart1.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };*/
            
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            //var imageSender = (Image)sender;
            if (tapCount % 2 == 0)
            {
                imageBtn.Source = ImageSource.FromResource("App3.Images.heart1.png");
            }
            else
            {
                imageBtn.Source = ImageSource.FromResource("App3.Images.heart2.png");
            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if(sender == btn1)
            {
                image.Source = ImageSource.FromResource("App3.Images.cat1.jpg");
            }
            else if (sender == btn2)
            {
                image.Source = ImageSource.FromResource("App3.Images.cat2.jpg");
            }
            else if (sender == btn3)
            {
                
                image.Source = ImageSource.FromResource("App3.Images.birb2.jpg");
            }
            else if (sender == btn4)
            {
                image.Source = ImageSource.FromResource("App3.Images.birb3.jpg");
            }
        }
    }
}
