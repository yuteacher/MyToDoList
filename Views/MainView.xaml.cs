using System.Windows;
using System.Windows.Input;

namespace MyToDoList.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            BtnMin.Click += (s, e) => { this.WindowState = WindowState.Minimized; };
            BtnClose.Click += (s, e) => { this.Close(); };
            BtnMax.Click += (s, e) =>
            {
                if (this.WindowState == WindowState.Normal)
                {
                    this.WindowState = WindowState.Maximized;
                }
                else
                {
                    this.WindowState = WindowState.Normal;
                }

            };
            ColorZone.MouseMove += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };
            menuBar.SelectionChanged += (s, e) =>
            {
                DrawerHost.IsLeftDrawerOpen = false;
            };
        }
    }
}
