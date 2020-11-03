using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MTsystem_win.allClass
{
    class userInfocheck
    {
        public string _usname;
        public string _uspwd;

        private string _Usname
        {
            get { return this._usname; }
            set { this._usname = value; }
        }

        private string _Uspwd
        {
            get { return this._uspwd; }
            set { this._uspwd = value; }
        }

        public bool testCheck()
        {
            if (_usname == "mtdk")
            {
                if(_uspwd=="123456")
                {
                    return true;
                }
            }
            return false;
        }

        public int usCheck(string usname, string uspwd)
        {
            Regex checkUsername = new Regex("^[A-Za-z0-9]+$");//用户名：英文和数字
            Regex checkUserpassword = new Regex("^[\u4e00-\u9fa5],{0,}$");//密码：不带中文

            var resultName = checkUsername.Match(usname);
            var resultPassword = checkUserpassword.Match(uspwd);
            if(!resultName.Success)
            {
                return 1;
            }
            else
            {
                if(!resultPassword.Success)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
