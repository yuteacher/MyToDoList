using MyToDoList.Common;
using MyToDoList.Common.Models;
using MyToDoList.Extensions;
using System.Collections.ObjectModel;

namespace MyToDoList.ViewModels
{
    public class MainViewModel : BindableBase ,IConfigureService
    {
        public MainViewModel(IRegionManager regionManager)
        {
            
            this.MenuBarSelectedCommand = new DelegateCommand<MenuBar>(MenuBarSelected);
            this.regionManager = regionManager;
            ForwardCommand = new DelegateCommand(() =>
            {
                if (journal != null && journal.CanGoForward)
                {
                    journal.GoForward();
                }
            });
            BackCommand = new DelegateCommand(() =>
            {
                if (journal != null && journal.CanGoBack)
                {
                    journal.GoBack();
                }
            });
        }

        private void MenuBarSelected(MenuBar bar)
        {
            if (bar == null || string.IsNullOrWhiteSpace(bar.NameSpace)) return;
            regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(bar.NameSpace, back =>
            {
                if (back.Context != null)
                    journal = back.Context.NavigationService.Journal;
            });
        }

        public DelegateCommand<MenuBar> MenuBarSelectedCommand { get; private set; }
        public DelegateCommand BackCommand { get; private set; }
        public DelegateCommand ForwardCommand { get; private set; }
        private ObservableCollection<MenuBar> menuBars;
        private readonly IRegionManager regionManager;
        private IRegionNavigationJournal journal;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { SetProperty(ref menuBars, value); }
        }
        void CreateMenuBars()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            menuBars.Add(new MenuBar() { Icon = "Home", Title = "首页", NameSpace = "IndexView" });
            menuBars.Add(new MenuBar() { Icon = "NotebookOutline", Title = "待办事项", NameSpace = "ToDoView" });
            menuBars.Add(new MenuBar() { Icon = "NotebookPlus", Title = "备忘录", NameSpace = "MemoView" });
            menuBars.Add(new MenuBar() { Icon = "Cog", Title = "设置", NameSpace = "SettingsView" });
        }

        public void Configure()
        {
            CreateMenuBars();
            regionManager.RegisterViewWithRegion(PrismManager.MainViewRegionName, "IndexView");
        }
    }
}
