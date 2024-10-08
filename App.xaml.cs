using System.Configuration;
using System.Data;
using System.Windows;
using Prism.Ioc;

namespace MyToDoList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void RegisterTypes( IContainerRegistry registry)
        {
        }
    }

}
