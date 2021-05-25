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
    /// Interaction logic for PageListStudent.xaml
    /// </summary>
    public partial class PageListStudent : Page
    {
        public PageListStudent()
        {
            InitializeComponent();

            Cmb_ChoiseGroup.SelectedValuePath = "Id";
            Cmb_ChoiseGroup.DisplayMemberPath = "NameGroup";
            Cmb_ChoiseGroup.ItemsSource = ClassDataBase.DBZachetStudents.Group.ToList();

        }

        private void Btn_Search_Click(object sender, RoutedEventArgs e)
        {

            ListStudent.SelectedValuePath = "Id";
            int x = Convert.ToInt32(Cmb_ChoiseGroup.SelectedValue);
            ListStudent.ItemsSource = ClassDataBase.DBZachetStudents.Student.Where(student => student.IdGroup == x).ToList();

        }

        private void Btn_Evaluation_Click(object sender, RoutedEventArgs e)
        {
            ListStudent.SelectedValuePath = "Id";
            ClassDataBase.obj = Convert.ToInt32(ListStudent.SelectedValue);
            ClassFrame.FrmMain.Navigate(new PageListEvaluation());
        }
            }
        } 