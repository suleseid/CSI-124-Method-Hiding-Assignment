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

namespace CSI_124_Method_Hiding_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object teachers;

        public MainWindow()
        {
            InitializeComponent();
 

        }

        private void btnAnimalCalls_Click(object sender, RoutedEventArgs e)
        {
            //What is instance?
            Animal animal = new Animal();
            Hippo hippo = new Hippo();
            BabyHippo tinyHungry = new BabyHippo();

            MessageBox.Show(tinyHungry.Sound());
            MessageBox.Show(hippo.Sound());

        }

        private void btnOpenAgregateWindow_Click(object sender, RoutedEventArgs e)
        {
            new Aggregate_Container.Agg_Contain_NoteAssignment().Show();
        }
    }
}
