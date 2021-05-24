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
using ZachetAcademyApp.DataBase;
using ZachetAcademyApp.Pages;

namespace ZachetAcademyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassDataBase.DBZachetStudents = new ZachetStudentsEntities();
            ClassFrame.FrmMain = FrmMainWindow;
            ClassFrame.BtnBack = Btn_Back;
            ClassFrame.FrmMain.Navigate(new PageMain());
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrmMain.GoBack();
            if (!ClassFrame.FrmMain.CanGoBack)

            {

                Btn_Back.Visibility = Visibility.Hidden;

            }

        }
    }
}
