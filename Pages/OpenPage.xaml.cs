using System;
using System.Collections.Generic;
using System.Text;
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
using System.Linq;

namespace CharacterSheetDbFirst.Pages
{
    /// <summary>
    /// Interaction logic for OpenPage.xaml
    /// </summary>
    public partial class OpenPage : Page
    {
        public OpenPage()
        {
            InitializeComponent();
        }

        private void BTN_newGame_Click(object sender, RoutedEventArgs e)
        {
            FRM_Smsp.Content = new StartModeSelectorPage();
        }
    }
}
