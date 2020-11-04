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
        public string _usid;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string _usname;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string _uspwd;
        /// <summary>
        /// 用户权限代码
        /// </summary>
        public int _uspowerid;
        /// <summary>
        /// 用户权限名称
        /// </summary>
        public string _uspowername;
        /// <summary>
        /// 部门代码
        /// </summary>
        public int _usdepartmentid;
        /// <summary>
        /// 部门名称
        /// </summary>
        public string _usdepartmentname;

        /// <summary>
        /// 用户代码
        /// </summary>
        private string _Usid
        {
            get { return this._usid; }
            set { this._usid = value; }
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        private string _Usname
        {
            get { return this._usname; }
            set { this._usname = value; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        private string _Uspwd
        {
            get { return this._uspwd; }
            set { this._uspwd = value; }
        }
        /// <summary>
        /// 用户权限代码
        /// </summary>
        private int _Uspowerid
        {
            get { return this._uspowerid; }
            set { this._uspowerid = value; }
        }
        /// <summary>
        /// 用户权限名称
        /// </summary>
        private string Uspowername
        {
            get { return this._uspowername; }
            set { this._uspowername = value; }
        }
        /// <summary>
        /// 部门代码
        /// </summary>
        private int Usdepartmentid
        {
            get { return this._usdepartmentid; }
            set { this._usdepartmentid = value; }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        private string Usdepartmentname
        {
            get { return this._usdepartmentname; }
            set { this._usdepartmentname = value; }
        }
    }
    #endregion
}