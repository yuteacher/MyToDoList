using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Common.Models
{
    public class BaseDto
    {


        public int Id;
        public DateTime createDate;
        public DateTime updateDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        public DateTime UpdateDate
        {
            get { return updateDate; }
            set { updateDate = value; }
        }

    }
}
