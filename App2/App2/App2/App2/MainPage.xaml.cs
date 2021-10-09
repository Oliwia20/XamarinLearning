using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            if(sender == btnGrid)
            {
                await Navigation.PushAsync(new GridLayout());
            }
            else if(sender == btnRelative)
            {
                await Navigation.PushAsync(new RelativeLayout());
            }
            else if (sender == btnAbsolute)
            {
                await Navigation.PushAsync(new AbsoluteLayout());
            }
            else if (sender == btnFlex)
            {
                await Navigation.PushAsync(new FlexLayout());
            }
        }
    }
}
