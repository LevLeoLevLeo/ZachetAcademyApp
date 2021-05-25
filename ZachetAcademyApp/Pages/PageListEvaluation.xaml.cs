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
    /// Логика взаимодействия для PageListEvaluation.xaml
    /// </summary>
    public partial class PageListEvaluation : Page
    {
        public PageListEvaluation()
        {
            InitializeComponent();
            ListEvaluation.ItemsSource = ClassDataBase.DBZachetStudents.Evaluation.Where(x => x.IdStudent == ClassDataBase.obj).ToList();

        }

        private void Btn_Print_Click(object sender, RoutedEventArgs e)
        {

            PrintDialog print = new PrintDialog();
            print.ShowDialog();
            print.PrintVisual(ListEvaluation, "");
        }
    }
}
