using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.GwcModels
{
    /// <summary>
    /// 结果输出类
    /// </summary>
    public class ResultOutPutModels<T> where T : class, new()
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public T Result { get; set; }
        /// <summary>
        /// 状态码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public string Msg { get; set; }
    }
}
