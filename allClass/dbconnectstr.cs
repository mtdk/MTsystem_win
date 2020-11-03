using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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

        MySqlDataAdapter _Gda;

        DataSet _Gds;

        string connstr = "server=127.0.0.1;uid=root;pwd=1;database=qhdatabase;charset=utf8;";

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
