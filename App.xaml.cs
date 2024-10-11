using MyToDoList.ViewModels;
using MyToDoList.Views;
using System.Windows;

namespace MyToDoList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }
        protected override void RegisterTypes(IContainerRegistry registry)
        {
            registry.RegisterForNavigation<SystemSettingView>();
            registry.RegisterForNavigation<AboutMoreView>();
            registry.RegisterForNavigation<IndividuationView, IndividuationViewModel>();
            registry.RegisterForNavigation<IndexView, IndexViewModel>();
            registry.RegisterForNavigation<ToDoView, ToDoViewModel>();
            registry.RegisterForNavigation<MemoView, MemoViewModel>();
            registry.RegisterForNavigation<SettingsView, SettingsViewModel>();

        }
    }

}
