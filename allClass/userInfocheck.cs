using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public bool usCheck(string usname, string uspwd)
        {
            if(usname=="mtdk")
            {
                if (uspwd == "123456")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
