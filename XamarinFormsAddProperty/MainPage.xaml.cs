using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsAddProperty
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var myButton = new ExtendedButton();
            myButton.Text = "Custom Message";

            myButton.BackgroundColor = Color.Red;
            var layout = (StackLayout)FindByName("myStackLayout");
            layout.Children.Add(myButton);
        }
    }
}
