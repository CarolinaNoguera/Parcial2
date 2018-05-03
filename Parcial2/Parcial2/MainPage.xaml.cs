using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Parcial2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void SINGIN(object sender, EventArgs e)
        {
            Navigation.PushAsync(new vista1());

        }


        private void IFORGOTMYPASSWORD(object sender, EventArgs e)
        {
            Navigation.PushAsync(new vista2());

        }


        private void SINGUP(object sender, EventArgs e)
        {
            Navigation.PushAsync(new vista3());

        }
        

    }
}
