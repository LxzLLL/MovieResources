using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Common
{
    /// <summary>
    /// 对string的扩展
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 指示指定的字符串是否为空
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsBlank(this string s)
        {
            if (string.IsNullOrEmpty(s) || s.Trim().Length == 0)
                return true;
            else
                return false;
        }
    }
}
