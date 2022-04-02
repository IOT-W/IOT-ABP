using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.GwcModels
{
    public class GwcInputRedis
    {
        public int SizeOrColorId { get; set; }  //规格Id
        public string Number { get; set; }      //商品编号
        public string Img { get; set; }         //图片
        public string Title { get; set; }       //标题
        public string Color { get; set; }       //颜色
        public string Size { get; set; }        //尺码
        public float Price { get; set; }        //单价
        public int Num { get; set; }            //数量
        public int Sku { get; set; }            //库存
    }
}
