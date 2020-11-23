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

        /// <summary>
        /// 材料库存窗口
        /// </summary>
        private static string _frmmsc;
        /// <summary>
        /// 材料库存窗口
        /// </summary>
        public static string _Frmmsc
        {
            set { _frmmsc = value; }
            get { return _frmmsc; }
        }

        /// <summary>
        /// 材料进仓窗口
        /// </summary>
        private static string _frmcljc;
        /// <summary>
        /// 材料进仓窗口
        /// </summary>
        public static string _Frmcljc
        {
            set { _frmcljc = value; }
            get { return _frmcljc; }
        }

        /// <summary>
        /// 材料期初库存录入窗口
        /// </summary>
        private static string _frmbsin;
        /// <summary>
        /// 材料期初库存录入窗口
        /// </summary>
        public static string _Frmbsin
        {
            set { _frmbsin = value; }
            get { return _frmbsin; }
        }
    }
}
