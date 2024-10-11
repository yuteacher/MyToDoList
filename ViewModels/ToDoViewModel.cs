using MyToDoList.Common.Models;
using System.Collections.ObjectModel;

namespace MyToDoList.ViewModels
{
     public class ToDoViewModel:BindableBase
    {
        public ToDoViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoDto>();
            CreateToDoItem();
            AddToDoCommand = new DelegateCommand(Add);
        }

        public DelegateCommand AddToDoCommand { get; private set; }

        private bool isRightDrawerOpen;

        private ObservableCollection<ToDoDto> _toDoItems;
        /// <summary>
        /// 右侧窗口是否打开
        /// </summary>
        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { SetProperty(ref isRightDrawerOpen, value); }
        }
        public ObservableCollection<ToDoDto> ToDoItems
        {
            get { return _toDoItems; }
            set { SetProperty(ref _toDoItems, value); }
        }
        void CreateToDoItem()
        {
            for(int i = 0; i < 30; i++)
            {
                ToDoItems.Add(new ToDoDto() { Title = "标题 " + i ,Content = "测试数据" });
            }
        }
        void Add()
        {
            IsRightDrawerOpen = true;
        }
    }
}
