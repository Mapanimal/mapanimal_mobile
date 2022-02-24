using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mapanimal.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if ((Color)etiqueta.GetValue(Label.TextColorProperty) == Color.Red)
            {
                etiqueta.TextColor = Color.Blue;
                etiqueta.SetValue(Label.TextColorProperty, Color.Blue);
            }
            else
            {
                etiqueta.TextColor = Color.Red;
            }
        }
    }
}