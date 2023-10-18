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
    public partial class Win : ContentPage
    {
        public Win() : this(5)
        {

        }

        public Win(int nombreMagique)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            NavigateBackToWelcomePage();

            MagiqueNumberLabel.Text = "Le nombre magique était: " + nombreMagique;
        }

        private async Task NavigateBackToWelcomePage()
        {
            await Task.Delay(3000);
            await Navigation.PopToRootAsync();
        }

        
        
            

    }
}