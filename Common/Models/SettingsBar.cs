using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Common.Models
{
    public class SettingsBar :BindableBase
    {
        private string icon;
        private string title;
        private string nameSpace;

        /// <summary>
        /// /设置图标
        /// </summary>
        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        /// <summary>
        /// 设置标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }

        }
        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace
        {
            get { return nameSpace; }
            set { nameSpace = value; }

        }
    }
}
