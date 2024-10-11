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
            DelegateCommand=new DelegateCommand<SettingsBar>(
                (parameter) =>
                {
                    this.regionManager.RequestNavigate(PrismManager.SettingsViewRegionName, parameter.NameSpace);
                });

        }
        public DelegateCommand<SettingsBar> DelegateCommand { get; private set; }
        private ObservableCollection<SettingsBar> settingsBars;
        public ObservableCollection<SettingsBar> SettingsBars
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
            settingsBars = new ObservableCollection<SettingsBar>();
            settingsBars.Add(new SettingsBar() { Title = "个性化", Icon = "Palette",NameSpace="IndividuationView" });
            settingsBars.Add(new SettingsBar() { Title = "系统设置", Icon = "Cog", NameSpace = "SystemSettingView" });
            settingsBars.Add(new SettingsBar() { Title = "关于更多", Icon = "Information", NameSpace = "AboutMoreView" });
        }

    }
}
