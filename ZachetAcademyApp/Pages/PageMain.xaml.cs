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
using ZachetAcademyApp.Class;

namespace ZachetAcademyApp.Pages
{
    /// <summary>
    /// Interaction logic for PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void Btn_AddStudent_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrmMain.Navigate(new PageAddStudent());
            ClassFrame.BtnBack.Visibility = Visibility.Visible;

        }

        private void Btn_AddEvaluation_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrmMain.Navigate(new PageAddEvaluation());
            ClassFrame.BtnBack.Visibility = Visibility.Visible;

        }

        private void Btn_ListStudent_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrmMain.Navigate(new PageListStudent());
            ClassFrame.BtnBack.Visibility = Visibility.Visible;

        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }
    }
}
