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
    /// Логика взаимодействия для RegPlayerPage.xaml
    /// </summary>
    public partial class RegPlayerPage : Page
    {
        public RegPlayerPage()
        {
            InitializeComponent();
            List<Game> list = App.db.Game.ToList();
            List<Comands> comands = App.db.Comands.ToList();
            OrganizCb.ItemsSource = comands;
            OrganizCb.DisplayMemberPath = "Name";
            GameDisc.ItemsSource = list;
            GameDisc.DisplayMemberPath = "Name";
            OrganizCb.SelectedValuePath = "Id";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(RetryPassw.Password == PasswPb.Password)
                {
                    if (!(App.db.Players.Any(x => x.Contact == ContactTb.Text) && (App.db.Comands.Any(x => x.Contact == ContactTb.Text))))
                    {
                        Players players = new Players();
                        players.Nick = NamePl.Text;
                        players.Contact = ContactTb.Text;
                        players.Password = PasswPb.Password;
                        players.Id_Organization = Convert.ToInt32(OrganizCb.SelectedValue);
                        App.db.Players.Add(players);
                        App.db.SaveChanges();
                        App.currentUs = players;
                        MessageBox.Show("Мы успешно зарегистрировали вас");
                        NavigationService.Navigate(new PlayersPage());
                    }
                    else
                    {
                        MessageBox.Show("Этот номер уже занят.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
                
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, проверьте введеные данные");
            }

            

        }
    }
}
