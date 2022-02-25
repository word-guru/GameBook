using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using GameBook.Lib;
using GameBook.Lib.Model;

namespace GameBook.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Game> Games { get; set; }
        public MainWindow()
        {
            Init();
            InitializeComponent();
            ListGames.ItemsSource = Games;
        }
        private void Init()
        {
            var db = new GameBookDb();
            
            Games = new ObservableCollection<Game>(db.GetAllGames());
        }
    }
}