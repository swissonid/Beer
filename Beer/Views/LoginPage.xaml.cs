using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Beer
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ShowFadinLoginStack();
        }

        async void ShowFadinLoginStack() {
			IsBusy = true;
            await LoginStackLayout.FadeTo(1, 2000);
            IsBusy = false;
        }
    }
}
