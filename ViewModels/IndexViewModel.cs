using MyToDo.Shared.Dtos;
using MyToDoList.Common.Models;
using System.Collections.ObjectModel;

namespace MyToDoList.ViewModels
{
    public class IndexViewModel : BindableBase
    {
        public IndexViewModel()
        {
            TaskBars = new ObservableCollection<TaskBar>();
            CreateTaskBars();
            CreateToDoDtos();

        }
        private ObservableCollection<TaskBar> taskBars;

        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set
            {
                SetProperty(ref taskBars, value);
            }
        }
        private ObservableCollection<ToDoDto> toDoDtos;

        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set
            {
                SetProperty(ref toDoDtos, value);
            }
        }
        private ObservableCollection<MemoDto> memoDtos;

        public ObservableCollection<MemoDto> MemoDtos
        {
            get { return memoDtos; }
            set
            {
                SetProperty(ref memoDtos, value);
            }
        }
        void CreateTaskBars()
        {
            TaskBars.Add(new TaskBar { Title = "汇总", Content = "9", Color = "#2F4F4F", Icon = "ClockFast", Target = "" });
            TaskBars.Add(new TaskBar { Title = "已完成", Content = "99", Color = "#43CD80", Icon = "ClockCheckOutline", Target = "" });
            TaskBars.Add(new TaskBar { Title = "完成比例", Content = "10%", Color = "#40E0D0", Icon = "ChartLineVariant", Target = "" });
            TaskBars.Add(new TaskBar { Title = "备忘录", Content = "88", Color = "#A0522D", Icon = "PlaylistStar", Target = "" });
        }
        void CreateToDoDtos()
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            MemoDtos = new ObservableCollection<MemoDto>();
            for (int i = 0; i < 10; i++)
            {
                ToDoDtos.Add(new ToDoDto { Title = "测试待办" + i, Content = "测试" + i });
                memoDtos.Add(new MemoDto { Title = "测试备忘" + i, Content = "测试" + i });
            }
        }
    }
}
