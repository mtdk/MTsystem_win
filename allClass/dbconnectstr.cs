using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MTsystem_win.allClass
{
    class dbconnectstr
    {
        public dbconnectstr()
        {
            //构造函数
        }

         MySqlConnection _Gcon;


        string connstr = "server=192.168.1.123;uid=testqh;pwd=123456;database=test;charset=utf8;";

        public MySqlConnection getCon()
        {
            _Gcon = new MySqlConnection(connstr);
            _Gcon.Open();
            return _Gcon;
        }

        public void _getClose()
        {
            if(getCon().State==ConnectionState.Open)
            {
                getCon().Close();
                getCon().Dispose();
            }
        }
    }
}
