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

namespace CharacterSheetDbFirst.Pages
{
    /// <summary>
    /// Interaction logic for StartModeSelectorPage.xaml
    /// </summary>
    public partial class StartModeSelectorPage : Page
    {
        public StartModeSelectorPage()
        {
            InitializeComponent();
        }

        private void BTN_newCharacter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_readyCharacter_Click(object sender, RoutedEventArgs e)
        {
            FRM_CreateOrSelect.Content = new SelectReadyCharacterPage();
        }

        private void BTN_back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
