/* Dominic Langowski
 * 4/19/2020 
 Good Times */
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

namespace CanadianTimeZones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTimezones_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            int Input;
            int Pacific;
            int Mountain;
            int Central;
            int Eastern;
            int Atlantic;
            int NewFoundLand;
            // Variables


            int.TryParse(txtInput.Text, out Input);

            Pacific = Input - 300;
            Mountain = Input - 200;
            Central = Input - 100;
            Eastern = Input;
            Atlantic = Input + 100;
            NewFoundLand = Input + 130;


            
            if (Pacific < 0)
            {
                lblOutputPacific.Content = 2400 + Pacific;
                
            }
            else if(Pacific > 0)
            {
                lblOutputPacific.Content = Pacific;
                
            }
         
            
            if(Mountain < 0)
            {
                lblOutputMountain.Content = 2400 + Mountain;
            }
           else if (Mountain > 0)
            {
                lblOutputMountain.Content = Mountain;
            }
             
            // The Outputs
            
            
            lblOutputCentral.Content = Central;
            lblOutputEastern.Content = Eastern;
            lblOutputAtlantic.Content = Atlantic;
            lblOutputNewFoundLand.Content = NewFoundLand;
            // The Outputs

        }
    }
}
