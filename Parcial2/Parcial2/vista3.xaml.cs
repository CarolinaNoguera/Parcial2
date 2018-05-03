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
	public partial class vista3 : ContentPage
	{
		public vista3 ()
		{
			InitializeComponent ();
		}

        private void inicio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }
        
    }
}