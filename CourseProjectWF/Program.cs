using System;
using System.Windows.Forms;

using Unity;

using DAL.Controller;
using DAL.Interface;
using Domain.Models;
using BLL.Interface;
using BLL.Services;

namespace CourseProjectWF
{
    static class Program
    {
        public static UnityContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();

            Login login = Container.Resolve<Login>();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<MainForm>());
            }
            else
            {
                Application.Exit();
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            /*Application.SetCompatibleTextRenderingDefault(false);*/
        }

        static private void ConfigureUnity()
        {
            Container = new UnityContainer();
            Container.RegisterType<ICategoryServices, CategoryServices>()
                     .RegisterType<IProductServices, ProductServices>()
                     .RegisterType<IUserServices, UserServices>()
                     .RegisterType<ICategoryRepository, CategoryRepository>()
                     .RegisterType<IProductRepository, ProductRepository>()
                     .RegisterType<IUserRepository, UserRepository>()
                     .RegisterType<MainForm,MainForm>();
        }
    }
}
