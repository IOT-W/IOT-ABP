using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.Skuk
{
    public class Skuinput
    {
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal ShopMarkPrice { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal ShopPrice { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int ShopNum { get; set; }
    }
}
