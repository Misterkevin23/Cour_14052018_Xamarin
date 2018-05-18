using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        double value1, value2;
        int currentState = 1;
        string mathOperator;


        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnSelectedNumber(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string value = btn.Text;

            if (resultText.Text=="0"||currentState<0)
            {
                resultText.Text = "";
                if (currentState<0)
                {
                    currentState *= -1;
                }
            }

            resultText.Text += value;

            double number;
            if (double.TryParse(resultText.Text, out number))
            {
                resultText.Text = number.ToString();
                if (currentState == 1)
                {
                    value1 = number;
                }
                else value2 = number;
            }
        }

        protected void OnSelectedOperator(Object sender, EventArgs e)
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
            resultText.Text = "0";
        }

        protected void OnCalculate(Object sender, EventArgs e)
        {
            if (currentState==2)
            {
                double result = SimpleCalculator.Calculate(value1, value2, mathOperator);
                resultText.Text = result.ToString();
                value1 = result;
                currentState = -1;
            }
        }
    }
}