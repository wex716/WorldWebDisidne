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
using WorrldWebDesign.Admin;
using WorrldWebDesign.Helpers;
using WorrldWebDesign.Teacher;
using WorrldWebDesign.Circle;

namespace WorrldWebDesign.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authentification.xaml
    /// </summary>
    public partial class Authentification : Page
    {
        private string Login = "";
        private string Password = "";

        public Authentification()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            try
            {
                if (TxbLogin.Text != null && TxbLogin.Text != "")
                {
                    if (PsbPasswd.Password != null)
                    {
                        Login = TxbLogin.Text;
                        Password = PsbPasswd.Password;

                        var result = Connecting.conn.User.FirstOrDefault(x => x.Email == Login && x.Password == Password);

                        if (result != null)
                        {
                            switch (result.Role.Name)
                            {
                                case "Student":
                                    Navigation.nav.Navigate(new PageCircleMain());
                                    break;

                                case "Админ":
                                    Navigation.nav.Navigate(new PageMainAdmin());
                                    break;

                                case "Преподаватель":
                                    Navigation.nav.Navigate(new PageMainTeacher());
                                    break;
                            }

                            MessageBox.Show($"Вы успешно авторизовались как {result.Role.Name}");
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Логин не может быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch
            {
                MessageBox.Show("Ошибка в обработке данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
