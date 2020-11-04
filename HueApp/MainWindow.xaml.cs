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
namespace HueApp
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

        private void findedieIp_Click(object sender, RoutedEventArgs e)
        {
            HueLogic.FindBridgeIP();
            txtIp.Text = HueLogic.BridgeIP;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                txtUsername.Text = "test";
            try
            {
                txtResult.Text = HueLogic.ConnectBridge(txtUsername.Text);
                txtUsername.Text = HueLogic.Usercode;
            } catch (Exception _ex)
            {
                Console.WriteLine($"Error: {_ex}");
            }
        }
    }
}
