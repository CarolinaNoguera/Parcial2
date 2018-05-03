using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Parcial2.Clases;


namespace Parcial2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vista5 : ContentPage
    {
        public vista5()
        {
            InitializeComponent();
        }
        public async void btn1_click(object sender, EventArgs e)
        {
            {
                try
                {
                    UserManager manager = new UserManager();
                    var res = await manager.getUsuarios();
                    System.Diagnostics.Debug.WriteLine(res);
                    if (res != null)
                    {
                        lstUsuarios.ItemsSource = res;
                    }
                }
                catch (Exception e1) { }
            }

        }
    }
}