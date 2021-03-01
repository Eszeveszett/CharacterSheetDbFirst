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

using Microsoft.EntityFrameworkCore;

//using CharacterSheetDbFirst.Models;
using CharacterSheetDbFirst.Pages;


namespace CharacterSheetDbFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FRM_Open.Content = new SelectReadyCharacterPage();
        }

        private void MI_Open_Click(object sender, RoutedEventArgs e)
        {
            FRM_Open.Content = new OpenPage();
        }

        private void MI_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void teszt()
        {
            
        }
    }
}
