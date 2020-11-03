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
        /// 用户名
        /// </summary>
        public string _usname;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string _uspwd;
        /// <summary>
        /// 用户权限
        /// </summary>
        public string _uspower;

        /// <summary>
        /// 用户名
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
        /// 用户权限
        /// </summary>
        private string _Uspower
        {
            get { return this._uspower; }
            set { this._uspower = value; }
        }
    }
    #endregion
}