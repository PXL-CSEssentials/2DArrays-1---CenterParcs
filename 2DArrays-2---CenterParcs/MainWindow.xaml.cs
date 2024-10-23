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

namespace _2DArrays_2___CenterParcs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[,] _houseWithPrice = new string[5, 2] {
            { "2 personen", "80" },
            { "4 personen", "120" } ,
            { "4 personen lux", "140" } ,
            { "6 personen", "180" },
            { "8 personen", "200"}
        };
        private readonly int[] _numberOfDays = new int[] { 1, 2, 5, 7, 8, 12, 14, 21 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadHouseType();
            LoadNumberOfDays();
        }

        private void LoadHouseType()
        {
            for (int i = 0; i < _houseWithPrice.GetLength(0); i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = _houseWithPrice[i, 0];
                houseTypeComboBox.Items.Add(item);
            }
        }
        private void LoadNumberOfDays()
        {
            for (int i = 0; i < _numberOfDays.Length; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = _numberOfDays[i].ToString();
                numberOfDaysComboBox.Items.Add(item);
            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            #region Type opzoeken
            //if (houseTypeComboBox.SelectedItem != null && numberOfDaysComboBox.SelectedItem != null)
            //{
            //    ComboBoxItem woningType = (ComboBoxItem)houseTypeComboBox.SelectedItem;
            //    ComboBoxItem aantalDagen = (ComboBoxItem)numberOfDaysComboBox.SelectedItem;
            //    int dagen = int.Parse(aantalDagen.Content.ToString());
            //    string type = woningType.Content.ToString();
            //    int indexVanType = IndexOfHouse(type);
            //    int prijsPerNacht = int.Parse(_houseWithPrice[indexVanType, 1]);
            //    totalPriceTextBox.Text = $"€ {dagen * prijsPerNacht}";
            //}
            #endregion
            if (houseTypeComboBox.SelectedIndex != -1 && numberOfDaysComboBox.SelectedIndex != -1)
            {
                int number = _numberOfDays[numberOfDaysComboBox.SelectedIndex];
                int price = int.Parse(_houseWithPrice[houseTypeComboBox.SelectedIndex, 1]);
                totalPriceTextBox.Text = $"€ {price * number}";
            }
        }

        #region Nodig voor "Type opzoeken"
        //private int IndexOfHouse(string type)
        //{
        //    int index = -1;

        //    for (int i = 0; i < _houseWithPrice.GetLength(0); i++)
        //    {
        //        if (_houseWithPrice[i, 0].Equals(type))
        //        {
        //            return i;
        //        }
        //    }

        //    return index;
        //}
        #endregion
    }
}
