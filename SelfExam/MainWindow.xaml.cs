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

namespace SelfExam
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

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            new ExamWindow().Show();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            new ExamWindow().Show();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            new ExamWindow().Show();
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
