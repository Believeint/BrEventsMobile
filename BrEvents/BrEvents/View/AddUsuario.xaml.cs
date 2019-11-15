using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrEvents.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUsuario : ContentPage
    {
        public AddUsuario()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}