using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;
=======
using System.Text.RegularExpressions;
>>>>>>> 49dc85b1134b53efebe5954c13ccf0f3bbea0935

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

        dbconnectstr dbcon = new dbconnectstr();
        public bool usCheck(string usname, string uspwd)
        {
            string sqlstr = "select userID,userPwd from user from user";

            MySqlCommand cmd = new MySqlCommand(sqlstr, dbcon.getCon());
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            try
            {
                if(rd.HasRows)
                {
                    return true;
                }
<<<<<<< HEAD
                else
                {
                    return false;
                }
            }
            finally
            {
                cmd.Dispose();
                rd.Dispose();
                dbcon.getCon();
            }
            
=======
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
>>>>>>> 49dc85b1134b53efebe5954c13ccf0f3bbea0935
        }
    }
}
