using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;

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
            
        }
    }
}
