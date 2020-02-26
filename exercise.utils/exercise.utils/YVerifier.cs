using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercise.utils
{
    public class YVerifier
    {
        /// <summary>
        /// 验证身份正确性
        /// </summary>
        /// <param name="info">身份证信息</param>
        /// <returns>true:正确身份证,false:错误身份证</returns>
        public bool CheckIDCard(string info)
        {
            Regex objReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return objReg.IsMatch(info);
        }

        /// <summary>
        /// 验证Email准确性 
        /// </summary>
        /// <param name="info">邮件信息</param>
        /// <returns>true:正确邮件,false:错误邮件</returns>
        public bool CheckEmail(string info)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return objReg.IsMatch(info);

        }

        /// <summary>
        /// 验证是否全部为中文
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:全部为中文，false:不全部为中文</returns>
        public bool CheckChineseChar(string info)
        {
            bool allC = true;
            for (int i = 0; i < info.Length; i++)
            {
                var cMatch=Regex.IsMatch(info[i].ToString(), "[\u4e00-\u9fbb]");
                if (cMatch)
                {
                    allC = false;
                    break;
                }
            }
            return allC;
        }

        /// <summary>
        /// 验证码是否为数值
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:全部为数值，false:不全部为数值</returns>
        public bool CheckNumber(string info)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(info);
        }

        /// <summary>
        /// 验证是否全部为大写英文
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:全部为大写英文，false:不全部为大写英文</returns>
        public bool CheckUpperCase(string info)
        {
            bool allC = true;
            for (int i = 0; i < info.Length; i++)
            {
                var cMatch = Regex.IsMatch(info[i].ToString(), "[A-Z]");
                if (cMatch)
                {
                    allC = false;
                    break;
                }
            }
            return allC;
        }

        /// <summary>
        /// 验证是否全部为小写写英文
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:全部为小写英文，false:不全部为小写英文</returns>
        public bool CheckLowerCase(string info)
        {
            bool allC = true;
            for (int i = 0; i < info.Length; i++)
            {
                var cMatch = Regex.IsMatch(info[i].ToString(), "[a-z]");
                if (cMatch)
                {
                    allC = false;
                    break;
                }
            }
            return allC;
        }

        /// <summary>
        /// 验证是否全部为英文字母
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:全部为英文，false:不全部为英文</returns>
        public bool CheckLetter(string info)
        {
            bool allC = true;
            for (int i = 0; i < info.Length; i++)
            {
                var cMatch = Regex.IsMatch(info[i].ToString(), "[a-zA-Z]");
                if (cMatch)
                {
                    allC = false;
                    break;
                }
            }
            return allC;
        }

        /// <summary>
        /// 验证座机电话准确性（国内）
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:正确，false:错误</returns>
        public bool CheckTelNumber(string info)
        {
            Regex regex = new Regex(@"((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)");
            return regex.IsMatch(info);
        }

        /// <summary>
        /// 验证手机号码准确性（国内）
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true:正确，false:错误</returns>
        public bool CheckMobileNumber(string info)
        {
            Regex regex = new Regex("^1[34578]\\d{9}$");
            return regex.IsMatch(info);
        }

        /// <summary>
        /// 验证网址准确性
        /// </summary>
        /// <param name="info"></param>
        /// <returns>tue:正确，false:错误</returns>
        public bool CheckUrl(string info)
        {
            return Regex.IsMatch(info, @"^(http|https)\://([a-zA-Z0-9\.\-]+(\:[a-zA-Z0-9\.&%\$\-]+)*@)*((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|localhost|([a-zA-Z0-9\-]+\.)*[a-zA-Z0-9\-]+\.(com|edu|gov|int|mil|net|org|biz|arpa|info|name|pro|aero|coop|museum|[a-zA-Z]{1,10}))(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\?\'\\\+&%\$#\=~_\-]+))*$");
        }
    }
}
