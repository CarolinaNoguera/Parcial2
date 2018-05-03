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
	public partial class vista1 : MasterDetailPage
    {
		public vista1 ()
		{
			InitializeComponent ();
            this.Master = new Master();// trae informacion de la vista 
            this.Detail = new NavigationPage(new Detail()); // carga los detalles de la vista Detail

            App.MasterD = this;
        }
	}
}