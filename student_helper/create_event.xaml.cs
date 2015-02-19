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
using System.Windows.Shapes;

namespace student_helper
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            typebox.Items.Add("Skema");
            typebox.Items.Add("Lektier");
            typebox.Items.Add("Andre");

            for (int i = 0; i < 24; i++ )
            {
                starthour.Items.Add(i);
                sluthour.Items.Add(i);
            }

            for (int i = 0; i < 60; i++)
            {
                startminute.Items.Add(i);
                slutminute.Items.Add(i);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            MessageBox.Show("Begivenheden er gemt");
        }

        private void typebox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void starthour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void startminute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sluthour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void slutminute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
