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

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<string> laiteCB = new List<string>();
        List<string> merkkiCB = new List<string>();

        Lisätoiminnot laiteTiet1 = new Lisätoiminnot("Mitsubishi ASX");
        Lisätoiminnot laiteTiet2 = new Lisätoiminnot("Ford Focus");
        Lisätoiminnot laiteTiet3 = new Lisätoiminnot("Honda CRV");

        Lisätoiminnot laiteTiet4 = new Lisätoiminnot("Suzuki GSXR");
        Lisätoiminnot laiteTiet5 = new Lisätoiminnot("KTM 990");
        Lisätoiminnot laiteTiet6 = new Lisätoiminnot("Yamaha R1");

        public MainWindow()
        {
            InitializeComponent();
            
            string ohje = "1. Valitse ajoneuvolaji ja klikkaa kohdasta laitetiedot" + "\n" + "2. Valitse ajoneuvo niin saat lisätietoa";
            returnInfo.Text = ohje;
        }

        
        private void laiteComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            laiteCB.Add("Autot");
            laiteCB.Add("Moottoripyörät");

            var CB = sender as ComboBox;
            CB.ItemsSource = laiteCB;
            CB.SelectedIndex = TabIndex;
        }

        private void laiteClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (laiteComboBox.SelectedItem.ToString() == "Autot")
                {
                    returnInfo11.Text = laiteTiet1.Laitetieto;
                    returnInfo22.Text = laiteTiet2.Laitetieto;
                    returnInfo33.Text = laiteTiet3.Laitetieto;
                }

                if (laiteComboBox.SelectedItem.ToString() == "Moottoripyörät")
                {
                    returnInfo11.Text = laiteTiet4.Laitetieto;
                    returnInfo22.Text = laiteTiet5.Laitetieto;
                    returnInfo33.Text = laiteTiet6.Laitetieto;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Valitse ajoneuvolaji ja paina kohdasta laitetiedot");
            }
        }

        public void VahvistaLaiteTiedot()
        {
            void Vahvista3()
            {

                if (MessageBox.Show("Klikkaamalla ohjaudut ajoneuvon tietokannan tietoihin",
                "Vahvista Chrome selaimen avaaminen", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    //
                }
            }
            Vahvista3();
        }
   
        private void returnInfo11Radio(object sender, RoutedEventArgs e)
        {
            if (returnInfo11.Text == laiteTiet1.Laitetieto)
            {
                VahvistaLaiteTiedot(); 

                expanDer1.IsExpanded = true;
                returnInfo.Text = "Web-sivuilla tarkemmat tiedot ajoneuvosta:\n" + laiteTiet1.Laitetieto; ;
                string laite = Lisätoiminnot.AutoMitsubishiASX();  
            }

            if (returnInfo11.Text == laiteTiet4.Laitetieto)
            {
                VahvistaLaiteTiedot(); 

                expanDer1.IsExpanded = true;
                returnInfo.Text = "Web-sivuilla tarkemmat tiedot ajoneuvosta:\n" + laiteTiet4.Laitetieto;
                string laite = Lisätoiminnot.MoottoripyörätSuzukiGSXR();  
            }
        }
 
        private void returnInfo22Radio(object sender, RoutedEventArgs e)
        {
            if (returnInfo22.Text == laiteTiet2.Laitetieto)
            {
                VahvistaLaiteTiedot(); 

                expanDer1.IsExpanded = true;
                returnInfo.Text = "Web-sivuilla tarkemmat tiedot ajoneuvosta:\n" + laiteTiet2.Laitetieto;
                string laite = Lisätoiminnot.AutoFordFocus(); 

            }

            if (returnInfo22.Text == laiteTiet5.Laitetieto)
            {

                VahvistaLaiteTiedot(); 

                expanDer1.IsExpanded = true;
                returnInfo.Text = "Web-sivuilla tarkemmat tiedot ajoneuvosta:\n" + laiteTiet5.Laitetieto;
                string laite = Lisätoiminnot.MoottoripyörätKTM990();  
            }
        }
   
        private void returnInfo33Radio(object sender, RoutedEventArgs e)
        {
            if (returnInfo33.Text == laiteTiet3.Laitetieto)
            {
                VahvistaLaiteTiedot(); 

                expanDer1.IsExpanded = true;
                returnInfo.Text = "Web-sivuilla tarkemmat tiedot ajoneuvosta:\n" + laiteTiet3.Laitetieto;
                string laite = Lisätoiminnot.AutoHondaCRV();  
            }

            if (returnInfo33.Text == laiteTiet6.Laitetieto)
            {
                VahvistaLaiteTiedot(); 

                expanDer1.IsExpanded = true;
                returnInfo.Text = "Web-sivuilla tarkemmat tiedot ajoneuvosta:\n" + laiteTiet6.Laitetieto;
                string laite = Lisätoiminnot.MoottoripyörätYamahaR1();  
            }
        }
    }
}
