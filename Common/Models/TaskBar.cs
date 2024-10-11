﻿namespace MyToDoList.Common.Models
{
    /// <summary>
    /// 任务栏
    /// </summary>
    public class TaskBar : BindableBase
    {
        private string icon;
        private string title;
        private string content;
        private string color;
        private string target;

        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Target
        {
            get { return target; }
            set { target = value; }
        }
    }
}
