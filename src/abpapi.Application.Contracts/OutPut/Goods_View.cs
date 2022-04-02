using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.OutPut
{
    public class Goods_View
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string Goods_Img { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Goods_Name { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public string Goods_Classification { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public string Goods_SalePrice { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public string Goods_MarketPrice { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public string Goods_Sku { get; set; }
        /// <summary>
        /// 上架
        /// </summary>
        public int Goods_Shelves { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Goods_Type { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string Goods_Coding { get; set; }
    }
}
