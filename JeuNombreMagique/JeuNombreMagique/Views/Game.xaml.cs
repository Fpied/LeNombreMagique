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
    public partial class Game : ContentPage
    {
        const int NB_MAGIQUE_MIN = 1;
        const int NB_MAGIQUE_MAX = 10;
        int nombreMagique = 0;
        public int nombreUtilisateur;
        public Game()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            nombreMagique = new Random().Next(NB_MAGIQUE_MIN, NB_MAGIQUE_MAX);
            minMaxLabel.Text = "Entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX;
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            // int nombreUtilisateur = Int32.Parse(numberEntry.Text);
            

            while(nombreMagique != nombreUtilisateur)
            {
                if (String.IsNullOrWhiteSpace(numberEntry.Text))
                {
                    DisplayAlert("Oups", "Vous devez rentrr un Nombre", "OK");
                    return;

                }

                int nombreUtilisateur = 0;
                try
                {
                    nombreUtilisateur = Int32.Parse(numberEntry.Text);

                }
                catch (Exception)
                {
                    DisplayAlert("Oups", "J'ai dis des nombres", "OK");
                    return;

                }
                

                if((nombreUtilisateur < NB_MAGIQUE_MIN) || (nombreUtilisateur > NB_MAGIQUE_MAX))
                {
                    DisplayAlert("Oups", "Vous devez rentrr un nombre entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX , "OK");
                    return;


                }
                if (nombreMagique > nombreUtilisateur)
                {
                    DisplayAlert("Oups", "Le nombre magique est supérieur à " + nombreUtilisateur, "OK");
                    return;
                }
                else if (nombreMagique < nombreUtilisateur)
                {
                    DisplayAlert("Oups", "Le nombre magique est inférieur à " + nombreUtilisateur, "OK");
                    return;

                }
                if (nombreMagique == nombreUtilisateur)
                {
                    WinAction();
                    
                    
                    break;

                }

            }

             
        }

        private async Task WinAction()
        {
            // await DisplayAlert("We", "ARE THE CHAMPIONS " + nombreUtilisateur, "OK");
            await this.Navigation.PushAsync(new Win(nombreMagique));
        }
    }
}