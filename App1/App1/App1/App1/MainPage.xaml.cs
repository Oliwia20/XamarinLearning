using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        int n = 0;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            //List<string> listaCytatow = new List<string>();

            slider.Value = 18;
            //label.FontSize = slider.Value;
            String[] listaCytatow = new String[5];
        }

        public String[] listaCytatow
        {
            get
            {
                return new String[5] { "Be yourself; everyone else is already taken.",
                    "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
                    "Knowing yourself is the beginning of all wisdom.",
                    "Only the very weak-minded refuse to be influenced by literature and poetry",
                    "It's the possibility of having a dream come true that makes life interesting"};
            }
        }

        /*public List<string> listaCytatow
        {
            get { return new List<string> { "Cytat 1", "Cytat 2", "Cytat 3", "Cytat4" }; }
        }*/
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(n == 5)
            {
                n = 0;
            }
            label.Text = listaCytatow[n];
            n++;
        }

        // slider.Value = 0.5;

    }
}
