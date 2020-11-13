using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTsystem_win.allClass
{
    /// <summary>
    /// 窗口状态控制类
    /// </summary>
    class frmShowstatus
    {
        /// <summary>
        /// 材料领用窗口
        /// </summary>
        private static string _frmclly;
        /// <summary>
        /// 材料领用窗口控制
        /// </summary>
        public static string _Frmclly
        {
            set { _frmclly = value; }
            get { return _frmclly; }
        }
    }
}
