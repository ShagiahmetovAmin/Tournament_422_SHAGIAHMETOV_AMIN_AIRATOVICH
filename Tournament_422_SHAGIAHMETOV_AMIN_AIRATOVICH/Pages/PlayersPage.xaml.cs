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
using Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH.Components;

namespace Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH.Pages
{
    /// <summary>
    /// Логика взаимодействия для PlayersPage.xaml
    /// </summary>
    public partial class PlayersPage : Page
    {
        public PlayersPage()
        {
            InitializeComponent();
            Refresh();

        }
        
        public void Refresh()
        {
            IEnumerable<Tournament> tournaments = App.db.Tournament.ToList();
            foreach(var  tournament in tournaments) 
            {
                TornamentReg.Children.Add(new TournamentRegUserControl(tournament));
            }

        }
    }
}
