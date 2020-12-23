using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTsystem_win.allClass
{
    class sendParameters
    {
        #region 材料退回

        private static string outid;    //材料出仓记录号
        private static string matid;    //材料系统编号
        private static string mat_id;   //材料编号
        private static string matInsideName;    //材料名
        private static string matnum;   //领用数量
        private static string matunit;  //材料规格
        private static string mattotal; //领用总量
        private static string outdate;  //领用时间
        private static string outOperator;  //操作人

        //材料出仓记录号
        public static string _Outid
        {
            get { return outid; }
            set { outid = value; }
        }
        //材料系统编号
        public static string _Matid
        {
            get { return matid; }
            set { matid = value; }
        }
        //材料编号
        public static string _Mat_id
        {
            get { return mat_id; }
            set { mat_id = value; }
        }
        //材料名
        public static string _MatinsideName
        {
            get { return matInsideName; }
            set { matInsideName = value; }
        }
        //领用数量
        public static string _Matnum
        {
            get { return matnum; }
            set { matnum = value; }
        }
        //材料规格
        public static string _Matunit
        {
            get { return matunit; }
            set { matunit = value; }
        }
        //领用总量
        public static string _MatTotal
        {
            get { return mattotal; }
            set { mattotal = value; }
        }
        //领用时间
        public static string _Outdate
        {
            get { return outdate; }
            set { outdate = value; }
        }
        //操作人
        public static string _OutOperator
        {
            get { return outOperator; }
            set { outOperator = value; }
        }


        #endregion
    }
}
