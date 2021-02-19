using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MTsystem_win.allClass
{
    /// <summary>
    /// 数值型数据判断
    /// </summary>
    class JudgeNumber
    {

        /// <summary>
        /// 构造函数，初始化函数作用
        /// </summary>
        public JudgeNumber()
        {
        }
        /// <summary>
        /// 所有数判断
        /// </summary>
        /// <param name="StrCode">验证参数</param>
        /// <returns>true or fals</returns>
        public bool ISNumeric(string StrCode)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            return !objNotNumberPattern.IsMatch(StrCode) && !objTwoDotPattern.IsMatch(StrCode) && !objTwoMinusPattern.IsMatch(StrCode) && objNumberPattern.IsMatch(StrCode);
        }

        public bool IntegralNumber(string IntStr)
        {
            Regex oboNumber = new Regex("[^0-9]");
            return !oboNumber.IsMatch(IntStr);
        }

    }
}
