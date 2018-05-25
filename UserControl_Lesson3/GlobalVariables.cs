using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControl_Lesson3.Properties;

namespace UserControl_Lesson3
{
    public static class GlobalVariables
    {
        public static Image[] _imgTimer = new Image[10] { Resources._0, Resources._1, Resources._2, Resources._3, Resources._4, Resources._5, Resources._6, Resources._7, Resources._8, Resources._9 };
        public static long _cntTimer = 0;
        public static bool _isStop = false;
        public static bool _isPause = false;
    }
}
