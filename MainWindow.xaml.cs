using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PierreFeuilleCiseaux;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public int? UserSelectVal = null;
    public int? ComputerRandomVal = null;
    Random random = new Random();

    //Regle : 
    //1 = Pierre
    //2 = Feuille 
    //3 = Sciseaux

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Pierre_Click(object sender, RoutedEventArgs e)
    {
        UserSelectVal = 1;
    }

    private void Feuille_Click(object sender, RoutedEventArgs e)
    {
        UserSelectVal = 2;
    }

    private void Sciseaux_Click(object sender, RoutedEventArgs e)
    {
        UserSelectVal = 3;
    }

    private void Jouer_Click(object sender, RoutedEventArgs e)
    {
        ComputerRandomVal = random.Next(1, 4);
        switch (UserSelectVal)
        {
            case null:  //USer select Pierre
                afficheResultat.Text = " Pour devez faire un choix avant de jouer";
                break;

            case 1:  //USer select Pierre

                if (ComputerRandomVal == 1) //User = Pierre , Ordi = Pierre  => Match Null
                {
                    afficheResultat.Text = " Match Null";
                }
                else if (ComputerRandomVal == 2) //User = Pierre , Ordi = Feuille  => User Perd
                {
                    afficheResultat.Text = "Vous avez perdu";
                }
                else if (ComputerRandomVal == 3) //User = Pierre , Ordi = Sciseaux => User Gagne
                {
                    afficheResultat.Text = "Bravo Vous avez gagner";
                }
                UserSelectVal = null;
                ComputerRandomVal = null;
                break;
            case 2: //USer select Feuille
                if (ComputerRandomVal == 1) //User = Feuille , Ordi = Pierre  => User Gagne
                {
                    afficheResultat.Text = "Bravo Vous avez gagner"; 
                }
                else if (ComputerRandomVal == 2) //User = Feuille , Ordi = Feuille  => Match Null
                {
                    afficheResultat.Text = " Match Null";
                }
                else if (ComputerRandomVal == 3) //User = Feuille , Ordi = Sciseaux => User Perd
                {
                    afficheResultat.Text = "Vous avez perdu"; 
                }
                UserSelectVal = null;
                ComputerRandomVal = null;
                break;
            case 3: //USer Select Sciseaux
                if (ComputerRandomVal == 1) //User = Sciseaux , Ordi = Pierre  => User Perd
                {
                    afficheResultat.Text = "Vous avez perdu"; 
                }
                else if (ComputerRandomVal == 2) //User = Sciseaux , Ordi = Feuille  => Match Gagne
                {
                    afficheResultat.Text = "Bravo Vous avez gagner"; 
                }
                else if (ComputerRandomVal == 3) //User = Sciseaux , Ordi = Sciseaux => UseMatch Null
                {
                    afficheResultat.Text = "Match Null";
                }
                UserSelectVal = null;
                ComputerRandomVal = null;
                break;

        }
    }
        
    }
