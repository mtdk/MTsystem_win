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
        #region 销售
        /// <summary>
        /// 客户信息窗口
        /// </summary>
        private static string _frmcustorminfo;
        /// <summary>
        /// 客户信息窗口
        /// </summary>
        public static string _Frmcustorminfo
        {
            set { _frmcustorminfo = value; }
            get { return _frmcustorminfo; }
        }
        #endregion

        #region 采购

        private static string _fsupinfo;

        public static string _Fsupinfo
        {
            set { _fsupinfo = value; }
            get { return _fsupinfo; }
        }

        #endregion

        #region 仓库
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

        /// <summary>
        /// 材料库存总报表窗口
        /// </summary>
        private static string _frmsrv;
        /// <summary>
        /// 材料库存总报表窗口
        /// </summary>
        public static string _Frmsrv
        {
            set { _frmsrv = value; }
            get { return _frmsrv; }
        }

        /// <summary>
        /// 材料进、出仓日报表窗口
        /// </summary>
        private static string _frdmsrv;
        /// <summary>
        /// 材料进、出仓日报表窗口
        /// </summary>
        public static string _Frdmsrv
        {
            set { _frdmsrv = value; }
            get { return _frdmsrv; }
        }

        /// <summary>
        /// 产品信息录入窗口
        /// </summary>
        private static string _frmproductinfo;
        /// <summary>
        /// 产品信息录入窗口
        /// </summary>
        public static string _Frmproductinfo
        {
            set { _frmproductinfo = value; }
            get { return _frmproductinfo; }
        }
        
        /// <summary>
        /// 材料退回确认窗口
        /// </summary>
        private static string _frmmatconfirm;
        /// <summary>
        /// 材料退回确认窗口
        /// </summary>
        public static string _Frmmatconfirm
        {
            get { return _frmmatconfirm; }
            set { _frmmatconfirm = value; }
        }

        /// <summary>
        /// 材料退货窗口
        /// </summary>
        private static string _frmmatreturngoods;
        /// <summary>
        /// 材料退货窗口
        /// </summary>
        public static string _Frmmatreturngoods
        {
            get { return _frmmatreturngoods; }
            set { _frmmatreturngoods = value; }
        }

        /// <summary>
        /// 产品进仓窗口
        /// </summary>
        private static string _frmproductinput;
        /// <summary>
        /// 产品进仓窗口
        /// </summary>
        public static string _Frmproductinput
        {
            get { return _frmproductinput; }
            set { _frmproductinput = value; }
        }

        /// <summary>
        /// 产品出仓窗口
        /// </summary>
        private static string _frmproductoutput;
        /// <summary>
        /// 产品出仓窗口
        /// </summary>
        public static string _Frmproductoutput
        {
            set { _frmproductoutput = value; }
            get { return _frmproductoutput; }
        }

        /// <summary>
        /// 产品进仓修改
        /// </summary>
        private static string _frmproductinputupdate;
        /// <summary>
        /// 产品进仓修改
        /// </summary>
        public static string _Frmproductinputupdate
        {
            set { _frmproductinputupdate = value; }
            get { return _frmproductinputupdate; }
        }

        /// <summary>
        /// 信封打印窗口
        /// </summary>
        private static string _frmenvelopeprint;
        /// <summary>
        /// 信封打印窗口
        /// </summary>
        public static string _Frmenvelopeprint
        {
            set { _frmenvelopeprint = value; }
            get { return _frmenvelopeprint; }
        }

        #endregion

        #region 车间
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
        /// 材料领用查询
        /// </summary>
        private static string _frmatouttquery;
        /// <summary>
        /// 材料领用查询
        /// </summary>
        public static string _Frmatouttquery
        {
            set { _frmatouttquery = value; }
            get { return _frmatouttquery; }
        }

        /// <summary>
        /// 材料回退查询窗口
        /// </summary>
        private static string _frmmatgivebckquery;
        /// <summary>
        /// 材料回退查询窗口
        /// </summary>
        public static string _FrmmatgiveBackQuery
        {
            set { _frmmatgivebckquery = value; }
            get { return _frmmatgivebckquery; }
        }
        #endregion

        #region 其他
        /// <summary>
        /// 标签录入窗口
        /// </summary>
        private static string _frmptag;
        /// <summary>
        /// 标签打印窗口
        /// </summary>
        public static string _Frmptag
        {
            set { _frmptag = value; }
            get { return _frmptag; }
        }

        #endregion

    }
}
