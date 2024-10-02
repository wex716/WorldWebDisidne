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
using WorrldWebDesign.Statement;
namespace WorrldWebDesign.Circle
{
    /// <summary>
    /// Логика взаимодействия для PageCircleMain.xaml
    /// </summary>
    public partial class PageCircleMain : Page
    {
        public PageCircleMain()
        {
            InitializeComponent();

            BtnBuy.Click += (sender, args) =>
            {
                NavigationService.Navigate(new PageStatmentMain());
            };

            
            BtnBuy1.Click += (sender, args) =>
            {
                NavigationService.Navigate(new PageStatmentMain());
            };


            BtnBuy2.Click += (sender, args) =>
            {
                NavigationService.Navigate(new PageStatmentMain());
            };


            BtnBuy3.Click += (sender, args) =>
            {
                NavigationService.Navigate(new PageStatmentMain());
            };


            BtnBu4.Click += (sender, args) =>
            {

                var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question);


                if (result == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                } else
                {
                    Application.Current.Shutdown();
                }
            };
           
        }
    }
}
