using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JeuNombreMagique
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
        void JouerNombreMagique(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Game());
        }
    }
}