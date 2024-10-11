using MyToDoList.Common.Models;
using System.Collections.ObjectModel;

namespace MyToDoList.ViewModels
{
    class MemoViewModel : BindableBase
    {
        public MemoViewModel()
        {
            MemoDtos = new ObservableCollection<MemoDto>();
            CreateToDoItem();
            AddToDoCommand = new DelegateCommand(Add);
        }

        public DelegateCommand AddToDoCommand { get; private set; }

        private bool isRightDrawerOpen;

        private ObservableCollection<MemoDto> memoDtos;
        /// <summary>
        /// 右侧窗口是否打开
        /// </summary>
        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { SetProperty(ref isRightDrawerOpen, value); }
        }
        public ObservableCollection<MemoDto> MemoDtos
        {
            get { return memoDtos; }
            set { SetProperty(ref memoDtos, value); }
        }
        void CreateToDoItem()
        {
            for (int i = 0; i < 30; i++)
            {
                MemoDtos.Add(new MemoDto() { Title = "标题 " + i, Content = "测试数据" });
            }
        }
        void Add()
        {
            IsRightDrawerOpen = true;
        }
    }
}
