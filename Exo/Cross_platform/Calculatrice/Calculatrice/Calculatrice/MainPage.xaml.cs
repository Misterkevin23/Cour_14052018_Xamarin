using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        double value1, value2;
        int currentState = 1;
        string mathOperator = "*";

        public MainPage()
        {
            InitializeComponent();
        }



        protected void OnElementSelect(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string value = btn.Text;

            if (resultat.Text == "0" || currentState < 0)
            {
                resultat.Text = "";
                if (currentState < 0)
                {
                    currentState *= -1;
                }
            }

            resultat.Text += value;

            double number;

            if (double.TryParse(resultat.Text, out number))
            {
                resultat.Text = number.ToString();

                if (currentState == 1)
                {
                    value1 = number;
                }
                else value2 = number;
            }


        }

        protected void OnOperatorSelect(Object sender, EventArgs e)
        {
            currentState = -2;
            Button btn = sender as Button;
            mathOperator = btn.Text;
        }

        protected void OnClear(Object sender, EventArgs e)
        {
            value1 = 0;
            value2 = 0;
            currentState = 1;
            resultat.Text = "0";
        }

        protected void OnCalculate(Object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                double result = Calculator.Calculate(value1, value2, mathOperator);
                resultat.Text = result.ToString();
                value1 = result;
                currentState = -1;

            }

        }

        //Navigation simple
        //async void OnAbout( Object sender, EventArgs e)
        //{
        //    var about = new  AboutPage();
        //    await this.Navigation.PushAsync(about);
        //}

        //Modal
        async void OnAbout(Object sender, EventArgs e)
        {
            var about = new AboutPage();
            await this.Navigation.PushModalAsync(about);
        }
    }
}
