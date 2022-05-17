using BLL.Interface;
using BLL.Services;
using CourseProjectWF;
using CourseProjectWPF.ViewModels;
using DAL.Controller;
using DAL.Interface;
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
using Unity;

namespace CourseProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static UnityContainer Container;
        public MainWindow()
        {
            ConfigureUnity();
            InitializeComponent();
            DataContext = Container.Resolve<MainWindowViewModel>();
        }
        

        static private void ConfigureUnity()
        {
            Container = new UnityContainer();
            Container.RegisterType<ICategoryServices, CategoryServices>()
                     .RegisterType<IProductServices, ProductServices>()
                     .RegisterType<IUserServices, UserServices>()
                     .RegisterType<ICategoryRepository, CategoryRepository>()
                     .RegisterType<IProductRepository, ProductRepository>()
                     .RegisterType<IUserRepository, UserRepository>();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }
        private void CloseCommandBinding_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)

        {
            if (MessageBox.Show("Close?", "Close", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
