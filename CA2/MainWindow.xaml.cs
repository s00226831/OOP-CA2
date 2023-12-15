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

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        // here is a link to the github page: https://github.com/s00226831/OOP-CA2

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnWin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoss_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GetData()
        {
            // this method creates all the data
            // creating teams
            // (this bit is off moodle)
            Team t1 = new Team() { Name = "France" };
            Team t2 = new Team() { Name = "Italy" };
            Team t3 = new Team() { Name = "Spain" };


            // creating the players
            // (this bit is also off moodle)

            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecords = "WWDDL"};
            Player p2 = new Player() { Name = "Claude", ResultRecords = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecords = "LWDLW" };

            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecords = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecords = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecords = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecords = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecords = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecords = "DDDDD" };

            // creating a team list and adding the teams
            List<Team> teamlist = new List<Team>();
            teamlist.Add(t1);
            teamlist.Add(t2);
            teamlist.Add(t3);

            // showing the team lists in the listbox
            lbxTeams.ItemsSource = teamlist;

            // adding players to teams
            t1.Players.Add(p1);
            t1.Players.Add(p2);
            t1.Players.Add(p3);
            t2.Players.Add(p4);
            t2.Players.Add(p5);
            t2.Players.Add(p6);
            t3.Players.Add(p7);
            t3.Players.Add(p8);
            t3.Players.Add(p9);

            // calculate points for each player
            p1.CalculatePoints();
            p2.CalculatePoints();
            p3.CalculatePoints();
            p4.CalculatePoints();
            p5.CalculatePoints();
            p6.CalculatePoints();
            p7.CalculatePoints();
            p8.CalculatePoints();
            p9.CalculatePoints();

            // calculate the teams totals points
            t1.Points = (p1.Points + p2.Points + p3.Points);
            t2.Points = (p4.Points + p5.Points + p6.Points);
            t3.Points = (p7.Points + p8.Points + p9.Points);

            
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //calls the getdata method when the window first loads up
            GetData();
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // When a team is selected it will show the players in it
            Team selected = lbxTeams.SelectedItem as Team;

            if (selected != null)
            {
                lbxPlayers.ItemsSource = selected.Players;
            }
        }

    


        

        
    }
}
