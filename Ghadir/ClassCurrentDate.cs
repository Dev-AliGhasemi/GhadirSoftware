using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghadir
{
    static class  ClassCurrentDate
    {
        static string currentDateNow;
        public static  string currentDate
        {
            get { return currentDateNow; }
            set { currentDateNow = value; }
        }
    }
}
