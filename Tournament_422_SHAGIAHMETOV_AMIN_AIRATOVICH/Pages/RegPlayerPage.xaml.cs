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
            OrganizCb.ItemsSource = list;
            OrganizCb.DisplayMemberPath = "Name";

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
                        Games_Players games = new Games_Players();
                        players.Nick = NamePl.Text;
                        players.Contact = ContactTb.Text;
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
