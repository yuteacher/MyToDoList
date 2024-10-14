using MyToDoList.Common;
using MyToDoList.Service;
using MyToDoList.ViewModels;
using MyToDoList.Views;
using Prism.Ioc;
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
        protected override void OnInitialized()
        {
            var service = App.Current.MainWindow.DataContext as IConfigureService;
            if(service != null)
                service.Configure();
            base.OnInitialized();
        }
        protected override void RegisterTypes(IContainerRegistry registry)
        {
            registry.GetContainer()
                .Register<HttpRestClient>(made: Parameters.Of.Type<string>(serviceKey: "webUrl"));
            registry.GetContainer().RegisterInstance(@"http://localhost:3389/", serviceKey: "webUrl");

            registry.Register<ILoginService, LoginService>();
            registry.Register<IToDoService, ToDoService>();
            registry.Register<IMemoService, MemoService>();
           // registry.Register<IDialogHostService, DialogHostService>();

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
