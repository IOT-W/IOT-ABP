using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.GwcModels
{ 
    public class GwcOutPutModels
    {
        public int SizeOrColorId { get; set; }  //规格Id
        public string Goods_Coding { get; set; }      //商品编号
        public string Goods_Img { get; set; }         //图片
        public string Goods_Name { get; set; }       //商品名称
        public string Color { get; set; }       //颜色
        public string Size { get; set; }        //尺码
        public float Goods_SalePrice { get; set; }        //销售价
        public float Goods_MarketPrice { get; set; } //市场价
        public int ShopNum { get; set; }            //数量
        public int Goods_Sku { get; set; }            //库存
    }
}

