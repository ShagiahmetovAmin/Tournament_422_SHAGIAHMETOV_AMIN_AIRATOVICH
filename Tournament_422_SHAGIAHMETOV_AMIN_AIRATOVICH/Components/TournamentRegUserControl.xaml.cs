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

namespace Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH.Components
{
    /// <summary>
    /// Логика взаимодействия для TournamentRegUserControl.xaml
    /// </summary>
    public partial class TournamentRegUserControl : UserControl
    {
        Tournament tournament;
        public TournamentRegUserControl(Tournament _tournament)
        {
            InitializeComponent();
            tournament = _tournament;
            NameTourn.Text = tournament.Name;
            PrizeTourn.Text = tournament.Prize_Fond.ToString();
            Order_Players order_Players = App.db.Order_Players.FirstOrDefault(x => x.Id_Players == App.currentUs.Id && x.Id_Tournament == tournament.Id);
            Status_Order status_Order = App.db.Status_Order.FirstOrDefault(x => x.Id == order_Players.Id_Status);
            Status.Text = "Статус заявки - " + status_Order.Name.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Order_Players order_Players = new Order_Players();
            order_Players.Id_Players = App.currentUs.Id;
            order_Players.Id_Tournament = tournament.Id;
            order_Players.Id_Status = 1;
            App.db.Order_Players.Add(order_Players);
            App.db.SaveChanges();
            MessageBox.Show("Записали тебя");
        }
    }
}
