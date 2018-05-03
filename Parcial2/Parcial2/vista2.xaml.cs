using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class vista2 : ContentPage
	{
		public vista2 ()
		{
			InitializeComponent ();
		}


        private async void vistaa6(object sender, EventArgs e)
        {
            String email = textemail.Text;
            await Navigation.PushAsync(new vista6(email));

        }
    }
}