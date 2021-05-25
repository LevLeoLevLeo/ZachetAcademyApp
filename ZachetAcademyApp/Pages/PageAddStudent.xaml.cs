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

namespace ZachetAcademyApp.Pages
{
    /// <summary>
    /// Interaction logic for PageAddStudent.xaml
    /// </summary>
    public partial class PageAddStudent : Page
    {
        public PageAddStudent()
        {
            InitializeComponent();
        
            Cmd_Specialization.SelectedValuePath = "Id";
            Cmd_Specialization.DisplayMemberPath = "NameSpecialization";
            Cmd_Specialization.ItemsSource = ClassDataBase.DBZachetStudents.Specialization.ToList();

            Cmd_TrainingForm.SelectedValuePath = "Id";
            Cmd_TrainingForm.DisplayMemberPath = "NameTrainingForm";
            Cmd_TrainingForm.ItemsSource = ClassDataBase.DBZachetStudents.TrainingForm.ToList();

            Cmd_NameGroup.SelectedValuePath = "Id";
            Cmd_NameGroup.DisplayMemberPath = "NameGroup";
            Cmd_NameGroup.ItemsSource = ClassDataBase.DBZachetStudents.Group.ToList();



        }

        private void Btn_AddStudent_Click(object sender, RoutedEventArgs e)
        {

            Student studentobj = new Student()

            {

                Name = Txb_NameStudent.Text,
                Specialization = Cmd_Specialization.SelectedItem as Specialization,
                Date = Dtp_Year.SelectedDate.Value,
                TrainingForm = Cmd_TrainingForm.SelectedItem as TrainingForm,
                Group = Cmd_NameGroup.SelectedItem as Group,
            };

            ClassDataBase.DBZachetStudents.Student.Add(studentobj);
            ClassDataBase.DBZachetStudents.SaveChanges();
            MessageBox.Show("Студент добавлен!", "Студент", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
