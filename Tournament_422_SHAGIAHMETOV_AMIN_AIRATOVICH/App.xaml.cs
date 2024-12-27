using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_422_SHAGIAHMETOV_AMIN_AIRATOVICHEntities db = new TournamentDB_422_SHAGIAHMETOV_AMIN_AIRATOVICHEntities();
        public static Players currentUs;
    }
}
