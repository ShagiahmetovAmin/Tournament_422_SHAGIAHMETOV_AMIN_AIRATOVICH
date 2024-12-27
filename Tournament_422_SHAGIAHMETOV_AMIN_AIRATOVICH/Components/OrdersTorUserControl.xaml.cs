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
    /// Логика взаимодействия для OrdersTorUserControl.xaml
    /// </summary>
    public partial class OrdersTorUserControl : UserControl
    {
        Order_Players order;
        public OrdersTorUserControl(Order_Players order_)
        {
            InitializeComponent();
            order = order_;
            UsName.Text = order.Games_Players.Players.Nick();
        }
    }
}
