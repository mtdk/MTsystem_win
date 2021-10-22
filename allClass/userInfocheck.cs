using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;
using System.Text.RegularExpressions;

namespace MTsystem_win.allClass
{
    #region
    /// <summary>
    /// 存储用户信息
    /// </summary>
    class userInfocheck
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        private static string _usid;
        /// <summary>
        /// 用户名称
        /// </summary>
        private static string _usname;
        /// <summary>
        /// 用户姓名
        /// </summary>
        private static string _username;
        /// <summary>
        /// 用户组代码
        /// </summary>
        private static int _ugroupid;
        /// <summary>
        /// 用户密码
        /// </summary>
        private static string _uspwd;
        /// <summary>
        /// 用户权限代码
        /// </summary>
        private static int _uspowerid;
        /// <summary>
        /// 用户权限名称
        /// </summary>
        private static string _uspowername;
        /// <summary>
        /// 部门代码
        /// </summary>
        private static int _usdepartmentid;
        /// <summary>
        /// 部门名称
        /// </summary>
        private static string _usdepartmentname;

        /// <summary>
        /// 用户代码
        /// </summary>
        public static string _Usid
        {
            get { return _usid; }
            set { _usid = value; }
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        public static string _Usname
        {
            get { return _usname; }
            set { _usname = value; }
        }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public static string _Username
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public static string _Uspwd
        {
            get { return _uspwd; }
            set { _uspwd = value; }
        }
        /// <summary>
        /// 用户组代码
        /// </summary>
        public static int _Ugroupid
        {
            get { return _ugroupid; }
            set { _ugroupid = value; }
        }
        /// <summary>
        /// 用户权限代码
        /// </summary>
        public static int _Uspowerid
        {
            get { return _uspowerid; }
            set { _uspowerid = value; }
        }
        /// <summary>
        /// 用户权限名称
        /// </summary>
        public static string _Uspowername
        {
            get { return _uspowername; }
            set { _uspowername = value; }
        }
        /// <summary>
        /// 部门代码
        /// </summary>
        public static int _Usdepartmentid
        {
            get { return _usdepartmentid; }
            set { _usdepartmentid = value; }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public static string _Usdepartmentname
        {
            get { return _usdepartmentname; }
            set { _usdepartmentname = value; }
        }
    }
    #endregion
}