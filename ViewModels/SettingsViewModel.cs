using MyToDoList.Common.Models;
using MyToDoList.Extensions;
using System.Collections.ObjectModel;

namespace MyToDoList.ViewModels
{
     public class SettingsViewModel: BindableBase
    {
        public SettingsViewModel(IRegionManager regionManager)
        {

            CreateSettingsBars();
            this.regionManager = regionManager;
            DelegateCommand=new DelegateCommand<MenuBar>(
                (parameter) =>
                {
                    this.regionManager.RequestNavigate(PrismManager.SettingsViewRegionName, parameter.NameSpace);
                });

        }
        public DelegateCommand<MenuBar> DelegateCommand { get; private set; }
        private ObservableCollection<MenuBar> settingsBars;
        public ObservableCollection<MenuBar> SettingsBars
        {
            get { return settingsBars; }
            set
            {
                SetProperty(ref settingsBars, value);
            }
        }
        private readonly IRegionManager regionManager;
        void CreateSettingsBars()
        {
            settingsBars = new ObservableCollection<MenuBar>();
            settingsBars.Add(new MenuBar() { Title = "个性化", Icon = "Palette",NameSpace="IndividuationView" });
            settingsBars.Add(new MenuBar() { Title = "系统设置", Icon = "Cog", NameSpace = "SystemSettingView" });
            settingsBars.Add(new MenuBar() { Title = "关于更多", Icon = "Information", NameSpace = "AboutMoreView" });
        }

    }
}
