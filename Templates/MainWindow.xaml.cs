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

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Personenliste { get; set; } = new ObservableCollection<Person>()
        {
            new Person(){Vorname="Rainer", Nachname="Zufall", Alter=45},
            new Person(){Vorname="Maria", Nachname="Meier", Alter=69},
            new Person(){Vorname="Anna", Nachname="Nass", Alter=13},
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this; ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button funktioniert");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Personenliste.Remove((sender as Button).Tag as Person);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            XmlDataProvider dataProvider = Spl_Xml.FindResource("xmlData") as XmlDataProvider;
            dataProvider.Document.Save(dataProvider.Source.LocalPath);
        }
    }
}
