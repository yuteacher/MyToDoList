using MaterialDesignColors;
using MaterialDesignColors.ColorManipulation;
using MaterialDesignThemes.Wpf;
using System.Windows.Media;

namespace MyToDoList.ViewModels
{
    public class IndividuationViewModel:BindableBase
    {
        private readonly PaletteHelper paletteHelper = new();
        private bool _isDarkTheme;
        public bool IsDarkTheme
        {
            get => _isDarkTheme;
            set
            {
                if (SetProperty(ref _isDarkTheme, value))
                {
                    ModifyTheme(theme => theme.SetBaseTheme(value ? BaseTheme.Dark : BaseTheme.Light));
                }
            }
        }

        public IEnumerable<ISwatch> Swatches { get;  }= SwatchHelper.Swatches;
        public DelegateCommand<object> ChangeHueCommand { get; private set; }

        public IndividuationViewModel()
        {
            ChangeHueCommand = new DelegateCommand<object>(ChangeHue);
        }
        private static void ModifyTheme(Action<Theme> modificationAction)
        {
            var paletteHelper = new PaletteHelper();
            Theme theme = paletteHelper.GetTheme();

            modificationAction?.Invoke(theme);

            paletteHelper.SetTheme(theme);
        }

        private void ChangeHue(object? obj)
        {
            var color = (Color)obj!;
            Theme theme = paletteHelper.GetTheme();
            theme.PrimaryLight = new ColorPair(color.Lighten());
            theme.PrimaryMid = new ColorPair(color);
            theme.PrimaryDark = new ColorPair(color.Darken());

            paletteHelper.SetTheme(theme);
        }
    }
}
