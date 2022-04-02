using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abpapi.ClassificationType
{
    public class Spu: Entity<Guid>
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 商品品牌
        /// </summary>
        public string ShopPin { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public string ShopSupplier { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        public string ShopType { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int ShopNum { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal ShopMarkPrice { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal ShopPrice { get; set; }
        /// <summary>
        /// 是否上架
        /// </summary>
        public bool Shelves { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public bool Mended { get; set; }
        /// <summary>
        /// 是否赠品
        /// </summary>
        public bool Gift { get; set; }
        /// <summary>
        /// 是否直播福利商品
        /// </summary>
        public bool Welfare { get; set; }
        /// <summary>
        /// 商品模型
        /// </summary>
        public string ShopModel { get; set; }
        /// <summary>
        /// 商品参数
        /// </summary>
        public string ShopParams { get; set; }
        /// <summary>
        /// 产品标签
        /// </summary>
        public string ShopLabel { get; set; }

    }
}
