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
    /// Interaction logic for PageAddEvaluation.xaml
    /// </summary>
    public partial class PageAddEvaluation : Page
    {
        public PageAddEvaluation()
        {
            InitializeComponent();
            WindowTitle = "Выставление оценок"; //Пытался сделать название окна, не работает.

            Cmb_Discipline.SelectedValuePath = "Id";                                            //Заполнение комбобокса с дисциплиной
            Cmb_Discipline.DisplayMemberPath = "NameDiscipline";
            Cmb_Discipline.ItemsSource = ClassDataBase.DBZachetStudents.Discipline.ToList();

            Cmb_Group.SelectedValuePath = "Id";
            Cmb_Group.DisplayMemberPath = "NameGroup";
            Cmb_Group.ItemsSource = ClassDataBase.DBZachetStudents.Group.ToList();

            Cmb_Student.SelectedValuePath = "Id";
            Cmb_Student.DisplayMemberPath = "Name";
            Cmb_Student.ItemsSource = ClassDataBase.DBZachetStudents.Student.ToList();
        }

        private void Btn_AddEvaluation_Click(object sender, RoutedEventArgs e)
        {

            if (Cmb_Discipline.SelectedItem == null || Cmb_Group.SelectedItem == null || Cmb_Student.SelectedItem == null || Txb_Evaluation.Text == null)

            {

                MessageBox.Show("Вы что-то не выбрали", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            else

            {

                if (Convert.ToInt32(Txb_Evaluation.Text) < 2 || Convert.ToInt32(Txb_Evaluation.Text) > 5)

                {

                    MessageBox.Show("Введена некорректная оценка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else

                {

                    Evaluation evaluationobj = new Evaluation()

                    {

                        Discipline = Cmb_Discipline.SelectedItem as Discipline,
                        Student = Cmb_Student.SelectedItem as Student,
                        Group = Cmb_Group.SelectedItem as Group,
                        Evaluation1 = Convert.ToInt32(Txb_Evaluation.Text),

                    };

                    ClassDataBase.DBZachetStudents.Evaluation.Add(evaluationobj);
                    ClassDataBase.DBZachetStudents.SaveChanges();
                    MessageBox.Show("Оценка поставлена!", "Оценка", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                }
        }

        private void Cmb_Group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int x = Convert.ToInt32(Cmb_Group.SelectedValue);
            Cmb_Student.ItemsSource = ClassDataBase.DBZachetStudents.Student.Where(y => y.IdGroup == x).ToList();

        }

        }
    }