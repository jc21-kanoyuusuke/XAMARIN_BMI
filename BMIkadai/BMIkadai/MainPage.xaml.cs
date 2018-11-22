using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMIkadai
{
    public partial class MainPage : ContentPage
    {
        double val;

        public MainPage()
        {
            InitializeComponent();
            keisan.Clicked += keisanClicked;
            keisan2.Clicked += keisanClicked2;
        }

        private void keisanClicked(object sender, EventArgs e)
        {
            float s = float.Parse(sin.Text);
            int t = int.Parse(tai.Text);
            if (s > 0 && s <= 3.0)
            {
                val = (t / s / s);
               
            }
            else if(s > 10 && s < 300)
            {
                val = (t / ((s / 100) * (s / 100)));
            }
            val = Math.Round(val, 1, MidpointRounding.AwayFromZero);
            string Val = val.ToString();
            bmi.Text = Val;
        }

        private void keisanClicked2(object sender, EventArgs e)
        {
            float s = float.Parse(sin.Text);
            int t = int.Parse(tai.Text);
            if (s > 0 && s <= 3.0)
            {
                val = (t / s / s);

            }
            else if (s > 10 && s < 300)
            {
                val = (t / ((s / 100) * (s / 100)));
            }
            val = Math.Round(val, 1, MidpointRounding.AwayFromZero);
            string Val = val.ToString();
            Navigation.PushModalAsync(new NavigationPage(new BmiResult(val)));
        }

    }

}
