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

namespace UPnPDetecter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Terminal> _terminals = new List<Terminal>();

        public MainWindow()
        {
            InitializeComponent();

            _terminals.Add(new Terminal(1, "PC1", "192.168.0.1", "xx:xx:xx:xx:xx:00"));
            _terminals.Add(new Terminal(2, "PC2", "192.168.0.2", "xx:xx:xx:xx:xx:01"));
            _terminals.Add(new Terminal(3, "PC3", "192.168.0.3", "xx:xx:xx:xx:xx:02"));

            TerminalsListView.ItemsSource = _terminals;
        }
    }
}
