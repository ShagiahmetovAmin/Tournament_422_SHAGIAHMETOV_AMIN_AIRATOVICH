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

namespace Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewTourPage.xaml
    /// </summary>
    public partial class NewTourPage : Page
    {
        public NewTourPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tournament tournament = new Tournament();
            tournament.Name = TName.Text;
            tournament.Start_date = Convert.ToDateTime(StartTor.Text);
            tournament.Prize_Fond = Convert.ToDecimal(PrizeFond.Text);
            App.db.Tournament.Add(tournament);
            App.db.SaveChanges();
        }
    }
}
