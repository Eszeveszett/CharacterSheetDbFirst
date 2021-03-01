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

using CharacterSheetDbFirst.Models;

using System.Linq;

namespace CharacterSheetDbFirst.Pages
{
    /// <summary>
    /// Interaction logic for SelectReadyCharacterPage.xaml
    /// </summary>
    public partial class SelectReadyCharacterPage : Page
    {
        dzetaContext context = new dzetaContext();
        public SelectReadyCharacterPage()
        {
            InitializeComponent();

            context.Races.Load();
            context.Characters.Load();

            //DG_PlayingCharacter.ItemsSource = context.Characters.Local.ToObservableCollection();
            LBO_PlayingCharacter.ItemsSource = context.Characters.Local.OrderBy(x=>x.Name).ToList();


            CBO_RaceSelector.ItemsSource = context.Races.Local.Select(x => x.RaceName).ToList().Distinct();
            CBO_RaceSelector.SelectedValue = "Select";


            CBO_GenderSelector.ItemsSource = context.Races.Local.Select(x => x.Gender).ToList().Distinct();
        }

        private void CBO_RaceSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var raceSelect = (from race in context.Races
                              where ((Races)CBO_RaceSelector.SelectedValue).Id == race.Id
                              select race).ToList();
            LBO_PlayingCharacter.ItemsSource = raceSelect;
            LBO_PlayingCharacter.Items.Refresh();
            
        }
    }
}
